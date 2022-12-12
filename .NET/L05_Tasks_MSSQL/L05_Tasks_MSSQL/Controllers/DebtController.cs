﻿using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.DebtDto;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DebtController : ControllerBase
    {
        private readonly BookStoreContext _db;
        private readonly IUserRepository _userRepo;
        private readonly ILibraryBookRepository _libraryBookRepo;
        private readonly IUserBookRepository _userBookRepo;
        private readonly IUserBookAdapter _adapter;

        public DebtController(BookStoreContext db, IUserBookRepository userBookRepo, IUserBookAdapter adapter, ILibraryBookRepository libraryBookRepo, IUserRepository userRepo)
        {
            _db = db;
            _userBookRepo = userBookRepo;
            _adapter = adapter;
            _libraryBookRepo = libraryBookRepo;
            _userRepo = userRepo;
        }

        /// <summary>
        /// Paskaiciuoja visas skolas, atnaujina duombaze ir grazina skolininku sarasa 
        /// </summary>
        /// <returns></returns>
        [HttpGet("CalculateAllDebts")]
        public ActionResult<List<UserDebtDto>> CalculateAllDebts()
        {
            List<GetUserDto> usersWithBooks = _userRepo.GetAll(u => u.TakenLibraryBooks > 0).ToList();
            List<UserBook> notReturnedBooks = _userBookRepo.GetAll(ub => ub.BookReturned == null).ToList();

            List<UserDebtDto> allUserDebt = new List<UserDebtDto>();

            foreach (var user in usersWithBooks)
            {
                UserDebtDto userDebt  = new UserDebtDto();
                userDebt.UserId = user.UserId;
                userDebt.UserFullName = user.FullName;
                userDebt.BooksNotReturnedInTime = new List<BookNotReturnedInTime>();
                userDebt.TotalDebt = 0;

                foreach (var userBook in notReturnedBooks)
                {
                    if (user.UserId == userBook.UserId)
                    {
                        var bookNotReturnedInTime = new BookNotReturnedInTime();
                        bookNotReturnedInTime.LibraryBookID = userBook.LibraryBookId;
                        bookNotReturnedInTime.BookTaken = userBook.BookTaken;
                        bookNotReturnedInTime.DaysLate = 0;

                        var daysPassed = (DateTime.Now - userBook.BookTaken).Days;
                        if (daysPassed > 28)
                        {
                            bookNotReturnedInTime.DaysLate = daysPassed - 28;
                            bookNotReturnedInTime.Debt = Math.Pow(bookNotReturnedInTime.DaysLate, 2)*0.2;
                            userDebt.TotalDebt += bookNotReturnedInTime.Debt;
                            userDebt.BooksNotReturnedInTime.Add(bookNotReturnedInTime);
                            _userBookRepo.UpdateDaysLate(userBook.Id, bookNotReturnedInTime.DaysLate);
                        }
                    }
                }                
                if(userDebt.TotalDebt > 0) allUserDebt.Add(userDebt);
            }

            foreach (var user in allUserDebt)
            {
                if (user.TotalDebt > 50) user.TotalDebt = 50;
                _userRepo.UpdateBooksNotReturnedInTimeAndTotalDebt(user.UserId, user.BooksNotReturnedInTime.Count, user.TotalDebt);
            }

            return Ok(allUserDebt);
        }
    }
}
