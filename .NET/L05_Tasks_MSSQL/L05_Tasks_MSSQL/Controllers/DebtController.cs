using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models.DTO.DebtDto;
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

        [HttpGet("GetAll")]
        public ActionResult<GetAllUserDebtResponse> GetAllUserDebt()
        {
            var usersWithBooks = _userRepo.GetAll(u => u.TakenLibraryBooks > 0);
            //var takenLibraryBooks = _libraryBookRepo.GetAll(lb => lb.IsTaken == true);
            var takenUserBooks = _userBookRepo.GetAll(ub => ub.BookReturned == null);

            //var groupByLastNamesQuery =
            //from student in students
            //group student by student.LastName into newGroup
            //orderby newGroup.Key
            //select newGroup;


            //var allUserDebt = new List<GetAllUserDebtResponse>();
            //foreach (var userBook in usersThatHaveBooks)
            //{
            //    allUserDebt.Add(
            //        new GetAllUserDebtResponse()
            //        {
            //            UserId = userBook.UserId,
            //            UserFullName = userBook.User.FullName,
            //            LibraryBookID = userBook.LibraryBookId,
            //            BookTaken = userBook.BookTaken
            //        });
            //}

            //var group = allUserDebt.GroupBy(
            //    a => a.UserId,
            //    a => a.LibraryBookID,
            //    (key, b) => new { UserId = key, TakenLibraryBookIds = b.ToList() }
            //    );
            //foreach (var item in group)
            //{
            //    item
            //}



            return Ok();
        }
    }
}
