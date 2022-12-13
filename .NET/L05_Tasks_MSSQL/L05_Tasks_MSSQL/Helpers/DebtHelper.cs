using L05_Tasks_MSSQL.Helpers.IHelpers;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.DebtDto;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using L05_Tasks_MSSQL.Repository.IRepository;

namespace L05_Tasks_MSSQL.Helpers
{
    public class DebtHelper : IDebtHelper
    {
        private readonly int _daysFromWhenDebtIsCounted = 28;
        private readonly int _debtDoesNotIncreaseAboveThisAmount = 50;
        private readonly IUserRepository _userRepo;
        private readonly IUserBookRepository _userBookRepo;

        public DebtHelper(IUserRepository userRepo, IUserBookRepository userBookRepo)
        {
            _userRepo = userRepo;
            _userBookRepo = userBookRepo;
        }


        public List<UserDebtDto> UpdateAndGetAllDebtForEveryone()
        {
            List<GetUserDto> usersWithBooks = _userRepo.GetAll(u => u.TakenLibraryBooks > 0).ToList();
            List<UserBook> notReturnedBooks = _userBookRepo.GetAll(ub => ub.BookReturned == null).ToList();

            List<UserDebtDto> allUserDebt = new List<UserDebtDto>();

            BuildListOfAllUsersInDebt(usersWithBooks, notReturnedBooks, allUserDebt);

            foreach (var user in allUserDebt)
            {
                if (user.TotalDebt > _debtDoesNotIncreaseAboveThisAmount) user.TotalDebt = _debtDoesNotIncreaseAboveThisAmount;
                _userRepo.UpdateBooksNotReturnedInTimeAndTotalDebt(user.UserId, user.BooksNotReturnedInTime.Count, user.TotalDebt);
            }
            return allUserDebt;
        }


        private void BuildListOfAllUsersInDebt(List<GetUserDto> usersWithBooks, List<UserBook> notReturnedBooks, List<UserDebtDto> allUserDebt)
        {
            foreach (var user in usersWithBooks)
            {
                UserDebtDto userDebt = new UserDebtDto();
                userDebt.UserId = user.UserId;
                userDebt.UserFullName = user.FullName;
                userDebt.BooksNotReturnedInTime = new List<BookNotReturnedInTime>();
                userDebt.TotalDebt = 0;

                BuildListOfBooksUserIsLateToReturn(notReturnedBooks, user, userDebt);

                if (userDebt.TotalDebt > 0) allUserDebt.Add(userDebt);
            }
        }


        private void BuildListOfBooksUserIsLateToReturn(List<UserBook> notReturnedBooks, GetUserDto user, UserDebtDto userDebt)
        {
            foreach (var userBook in notReturnedBooks)
            {
                if (user.UserId == userBook.UserId)
                {
                    var bookNotReturnedInTime = new BookNotReturnedInTime();
                    bookNotReturnedInTime.LibraryBookID = userBook.LibraryBookId;
                    bookNotReturnedInTime.BookTaken = userBook.BookTaken;
                    bookNotReturnedInTime.DaysLate = 0;

                    var daysPassed = (DateTime.Now - userBook.BookTaken).Days;
                    if (daysPassed > _daysFromWhenDebtIsCounted)
                    {
                        bookNotReturnedInTime.DaysLate = daysPassed - _daysFromWhenDebtIsCounted;
                        bookNotReturnedInTime.Debt = Math.Pow(bookNotReturnedInTime.DaysLate, 2)*0.2;
                        userDebt.TotalDebt += bookNotReturnedInTime.Debt;
                        userDebt.BooksNotReturnedInTime.Add(bookNotReturnedInTime);
                        _userBookRepo.UpdateDaysLate(userBook.Id, bookNotReturnedInTime.DaysLate);
                    }
                }
            }
        }
    }
}
