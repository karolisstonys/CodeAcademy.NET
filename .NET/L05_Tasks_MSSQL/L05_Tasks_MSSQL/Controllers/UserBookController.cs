using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Repository;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserBookController : ControllerBase
    {
        private readonly BookStoreContext _db;
        private readonly IUserBookRepository _userBookRepo;
        private readonly IUserBookAdapter _adapter;

        public UserBookController(BookStoreContext db, IUserBookRepository userBookRepo, IUserBookAdapter adapter)
        {
            _db = db;
            _userBookRepo = userBookRepo;
            _adapter = adapter;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<UserBook>> GetAction()
        {
            return _userBookRepo.GetAll();
        }

        [HttpGet("Get/{id:int}")]
        public ActionResult<UserBook> GetUserBookById(int id)
        {
            return _userBookRepo.Get(ub => ub.UserId == id);
        }

        [HttpPost("TakeLibraryBook")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<GetUserBookDto> TakeLibraryBook(CreateUserBookDto createUserBookDto)
        {
            if (createUserBookDto == null) return BadRequest();

            var libraryBook = _db.LibraryBooks.FirstOrDefault(b => b.Id == createUserBookDto.LibraryBookId);
            if (libraryBook == null) return NotFound();

            var isTaken = libraryBook.IsTaken;
            if (isTaken) return NotFound("Book is already taken");

            var user = _db.Users.FirstOrDefault(b => b.Id == createUserBookDto.UserId);
            if (user == null) return NotFound();

            UserBook newUserBook = _adapter.Adapt(user, libraryBook);
            _userBookRepo.Create(newUserBook);

            GetUserBookDto getUserBookDto = _adapter.Adapt(newUserBook);

            return CreatedAtAction(nameof(GetUserBookById), new { id = getUserBookDto.UserId }, getUserBookDto);
        }

    }
}
