using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LibraryBookController : ControllerBase
    {
        private readonly BookStoreContext _db;
        private readonly ILibraryBookAdapter _adapter;
        private readonly ILibraryBookRepository _libraryBookRepo;

        public LibraryBookController(BookStoreContext db, ILibraryBookRepository libraryBookRepository, ILibraryBookAdapter adapter)
        {
            _db = db;
            _libraryBookRepo = libraryBookRepository;
            _adapter = adapter;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<GetLibraryBookDto>> GetLibraryBooks()
        {
            var allLibraryBooks = _libraryBookRepo.GetAll();
            return Ok(_adapter.Adapt(allLibraryBooks));
        }

        [HttpGet("Get/{id:int}")]
        public ActionResult<GetLibraryBookDto> GetLibraryBookById(int id)
        {
            var libraryBook = _libraryBookRepo.Get(lb => lb.Id == id);
            //libraryBook.Book = _db.Books.FirstOrDefault(b => b.Id == libraryBook.BookId);
            if (libraryBook == null) return NotFound();
            return Ok(_adapter.Adapt(libraryBook));
        }

        [HttpPost("Add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<GetLibraryBookDto> AddLibraryBook(CreateLibraryBookDto createLibraryBookDto)
        {
            if (createLibraryBookDto == null || createLibraryBookDto.BookISBN == "") return BadRequest();

            var book = _db.Books.FirstOrDefault(b => b.ISBN == createLibraryBookDto.BookISBN);
            if (book == null) return NotFound();

            LibraryBook newLibraryBook = _adapter.Adapt(createLibraryBookDto.BookISBN, book);
            _libraryBookRepo.Create(newLibraryBook);
            GetLibraryBookDto getLibraryBookDto = _adapter.Adapt(newLibraryBook);

            return CreatedAtAction(nameof(GetLibraryBookById), new { id = newLibraryBook.Id }, getLibraryBookDto);
        }

        [HttpPost("AddMany/{count:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult AddManyLibraryBooks(CreateLibraryBookDto libraryBookDto, int count)
        {
            if (libraryBookDto == null || libraryBookDto.BookISBN == "" || count <= 0) return BadRequest();

            var book = _db.Books.FirstOrDefault(b => b.ISBN == libraryBookDto.BookISBN);
            if (book == null) return NotFound();

            for (int i = 0; i < count; i++)
            {
                LibraryBook newLibraryBook = _adapter.Adapt(libraryBookDto.BookISBN, book);
                _libraryBookRepo.Create(newLibraryBook);
            }

            return Ok();
        }

        [HttpDelete("Delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteLibraryBookById(int id)
        {
            var libraryBook = _libraryBookRepo.Get(lb => lb.Id == id);
            if (libraryBook == null) return NotFound();

            while (_db.UserBooks.FirstOrDefault(ub => ub.LibraryBookId == id) != null)
            {
                var userBook = _db.UserBooks.First(ub => ub.LibraryBookId == id);
                _db.UserBooks.Remove(userBook);
                _db.SaveChanges();
            }

            _libraryBookRepo.Remove(libraryBook);

            return NoContent();
        }














    }
}
