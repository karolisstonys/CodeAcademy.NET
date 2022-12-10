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

        [HttpGet("All")]
        public ActionResult<List<GetLibraryBookDto>> GetLibraryBooks()
        {
            var allLibraryBooks = _libraryBookRepo.GetAll();
            return Ok(_adapter.Adapt(allLibraryBooks));
        }

        [HttpGet("{id:int}")]
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

            LibraryBook newLibraryBook = new LibraryBook()
            {
                BookISBN = createLibraryBookDto.BookISBN,
                Book = book,
                IsTaken = false,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };

            _libraryBookRepo.Create(newLibraryBook);
            GetLibraryBookDto getLibraryBookDto = _adapter.Adapt(newLibraryBook);

            return CreatedAtAction(nameof(GetLibraryBookById), new { id = newLibraryBook.Id }, getLibraryBookDto);
        }

        [HttpPost("AddMany/{count:int}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddManyLibraryBooks(CreateLibraryBookDto libraryBookDto, int count)
        {
            if (libraryBookDto == null || libraryBookDto.BookISBN == "" || count <= 0) return BadRequest();

            var book = _db.Books.FirstOrDefault(b => b.ISBN == libraryBookDto.BookISBN);
            if (book == null) return NotFound();

            for (int i = 0; i < count; i++)
            {
                LibraryBook newLibraryBook = new LibraryBook()
                {
                    BookISBN = libraryBookDto.BookISBN,
                    Book = book,
                    IsTaken = false,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                };

                _libraryBookRepo.Create(newLibraryBook);
            }

            return Ok();
        }














    }
}
