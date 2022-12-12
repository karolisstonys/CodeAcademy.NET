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
        private readonly IUserRepository _userRepo;
        private readonly IUserBookAdapter _adapter;

        public UserBookController(BookStoreContext db, IUserBookRepository userBookRepo, IUserBookAdapter adapter, ILibraryBookRepository libraryBookRepo, IUserRepository userRepo)
        {
            _db = db;
            _userBookRepo = userBookRepo;
            _adapter = adapter;
            _libraryBookRepo = libraryBookRepo;
            _userRepo = userRepo;
        }

        /// <summary>
        /// Grazina visa imtu knygu istorija
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public ActionResult<List<GetUserBookDto>> GetAction()
        {
            var getUserBookDtoList = _userBookRepo.GetAll()
                                                  .Select(userBooks => _adapter.Adapt(userBooks))
                                                  .ToList();
            return getUserBookDtoList;
        }

        /// <summary>
        /// Grazina vieno kliento imtu knygu istorija
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id:int}")]
        public ActionResult<GetUserBookDto> GetUserBookById(int id)
        {
            var userBook = _userBookRepo.Get(ub => ub.UserId == id);
            return _adapter.Adapt(userBook);
        }

        /// <summary>
        /// Paimti knyga is bibliotekos
        /// </summary>
        /// <param name="createUserBookDto">Parametrai: kas ima knyga ir kokia ima knyga</param>
        /// <returns></returns>
        [HttpPost("TakeLibraryBook")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<GetUserBookDto> TakeLibraryBook(CreateUserBookDto createUserBookDto)
        {
            if (createUserBookDto == null) return BadRequest();

            var libraryBook = _libraryBookRepo.Get(b => b.Id == createUserBookDto.LibraryBookId);
            if (libraryBook == null) return NotFound();

            var isTaken = libraryBook.IsTaken;
            if (isTaken) return NotFound("Book is already taken");

            var getUserDto = _userRepo.Get(b => b.Id == createUserBookDto.UserId);
            if (getUserDto == null) return NotFound();
            if (getUserDto.TakenLibraryBooks >= 5) return Conflict("User has too many books taken already");
            if (getUserDto.BooksNotReturnedInTime >= 2) return Conflict("User has too many books not returned in time");
            if (getUserDto.TotalDebt >= 10) return Conflict("User has too much debt");

            UserBook newUserBook = _adapter.Adapt(getUserDto, libraryBook);
            _userBookRepo.Create(newUserBook);

            libraryBook.IsTaken = true;
            _libraryBookRepo.Update(libraryBook);
                        
            _userRepo.UpdateTakenLibraryBooks(getUserDto.UserId, +1);

            GetUserBookDto getUserBookDto = _adapter.Adapt(newUserBook);

            return CreatedAtAction(nameof(GetUserBookById), new { id = getUserBookDto.UserId }, getUserBookDto);
        }

        /// <summary>
        /// Graziname knyga i biblioteka
        /// </summary>
        /// <param name="id">bibliotekos knygos id</param>
        /// <returns></returns>
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

            _userRepo.UpdateTakenLibraryBooks(userBook.UserId, -1);

            return NoContent();
        }

    }
}
