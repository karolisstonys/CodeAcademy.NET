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
        private readonly ILibraryBookRepository _libraryBookRepo;
        private readonly IUserBookAdapter _adapter;

        public UserBookController(BookStoreContext db, IUserBookRepository userBookRepo, IUserBookAdapter adapter, ILibraryBookRepository libraryBookRepo)
        {
            _db = db;
            _userBookRepo = userBookRepo;
            _adapter = adapter;
            _libraryBookRepo = libraryBookRepo;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<GetUserBookDto>> GetAction()
        {
            var getUserBookDtoList = _userBookRepo.GetAll()
                                                  .Select(userBooks => _adapter.Adapt(userBooks))
                                                  .ToList();
            return getUserBookDtoList;
        }

        [HttpGet("Get/{id:int}")]
        public ActionResult<GetUserBookDto> GetUserBookById(int id)
        {
            var userBook = _userBookRepo.Get(ub => ub.UserId == id);
            return _adapter.Adapt(userBook);
        }

        [HttpPost("TakeLibraryBook")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<GetUserBookDto> TakeLibraryBook(CreateUserBookDto createUserBookDto)
        {
            if (createUserBookDto == null) return BadRequest();

            var libraryBook = _libraryBookRepo.Get(b => b.Id == createUserBookDto.LibraryBookId);
            if (libraryBook == null) return NotFound();

            var isTaken = libraryBook.IsTaken;
            if (isTaken) return NotFound("Book is already taken");

            var user = _db.Users.FirstOrDefault(b => b.Id == createUserBookDto.UserId);
            if (user == null) return NotFound();

            UserBook newUserBook = _adapter.Adapt(user, libraryBook);
            _userBookRepo.Create(newUserBook);

            libraryBook.IsTaken = true;
            _libraryBookRepo.Update(libraryBook);

            GetUserBookDto getUserBookDto = _adapter.Adapt(newUserBook);

            return CreatedAtAction(nameof(GetUserBookById), new { id = getUserBookDto.UserId }, getUserBookDto);
        }

        [HttpPut("ReturnLibraryBook/{id:int}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult ReturnLibraryBookById(int id)
        {
            var userBook = _userBookRepo.Get(b => b.Id == id);
            if (userBook == null) return NotFound();

            var libraryBook = _libraryBookRepo.Get(b => b.Id == userBook.LibraryBookId);
            if (libraryBook == null) return NotFound();

            userBook.BookReturned = DateTime.Now;
            _userBookRepo.Update(userBook);

            libraryBook.IsTaken = false;
            _libraryBookRepo.Update(libraryBook);

            return NoContent();
        }

    }
}
