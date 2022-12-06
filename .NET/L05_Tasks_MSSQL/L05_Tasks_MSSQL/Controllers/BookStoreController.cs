using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {

        private readonly BookStoreContext _db;
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<BookStoreController> _logger;
        private readonly IBookRepository _bookRepo;

        public BookStoreController(BookStoreContext db, IBookWrapper wrapper, ILogger<BookStoreController> logger, IBookRepository bookRepo)
        {
            _db = db;
            _wrapper = wrapper;
            _logger = logger;
            _bookRepo = bookRepo;
        }

        /// <summary>
        /// Uzklausia visu knygu is duomenu bazes
        /// </summary>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma visos knygos</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("AllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<IEnumerable<GetBookDto>> GetBooks()
        {
            _logger.LogInformation("HttpGet AllBooks() buvo iskvietas {0} ", DateTime.Now);
            try
            {
                return Ok(_bookRepo.GetAll()
                    //_db.Books
                    .Select(book => _wrapper.Bind(book))
                    .ToList());
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpGet AllBooks() nuluzo {0}", DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Uzklausia knyga is duomenu bazes pagal specijini id
        /// </summary>
        /// <param name="id">Uzklausiamos knygos id</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma vienos knygos informacija</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("GetSingleBook/{id:int}", Name = "GetBook")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<GetBookDto> GetBookById(int id)
        {
            _logger.LogInformation("HttpGet GetBookById(id = {0}) buvo iskvietas {1} ", id, DateTime.Now);
            try
            {
                if (id == 0)
                {
                    _logger.LogError("HttpGet GetBookById(id = {0}) su blogu id {1} ", id, DateTime.Now);
                    return NotFound(); // return BadRequest();
                }

                var book = _bookRepo.Get(b => b.Id == id);
                    //_db.Books.FirstOrDefault(a => a.Id == id);
                if (book == null)
                {
                    _logger.LogError("HttpGet GetBookById(id = {0}) knyga su tokiu id nerasta {1} ", id, DateTime.Now);
                    return NotFound();
                }

                return Ok(_wrapper.Bind(book));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpGet GetBookById(id = {0}) nuluzo {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Sukuria nauja knyga
        /// </summary>
        /// <param name="createBookDto">Knygos objektas</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="201">Sekmingai sukuriama nauja knyga</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPost("CreateBook")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<CreateBookDto> CreateBook(CreateBookDto createBookDto)
        {
            _logger.LogInformation("HttpPost CreateBook(createBookDto = {0}) buvo iskvietas {1} ", JsonConvert.SerializeObject(createBookDto), DateTime.Now);
            try
            {
                if (createBookDto == null)
                {
                    _logger.LogError("HttpPost CreateBook(createBookDto) createBookDto objektas == null {1} ", DateTime.Now);
                    return BadRequest();
                }

                Book newBook = _wrapper.Bind(createBookDto);

                _bookRepo.Create(newBook);
                //_db.Books.Add(newBook);
                //_db.SaveChanges();

                return CreatedAtRoute("GetBook", new { id = newBook.Id }, createBookDto);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpPost GetBookById(createBookDto = {0}) nuluzo {1} ", JsonConvert.SerializeObject(createBookDto), DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Knygu filtravimas pagal pavadinima arba autoriu
        /// </summary>
        /// <param name="title">Pavadinimo filtras</param>
        /// <param name="author">Autoriaus filtras</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Grazina visas rastas knygas pagal ivestus filtrus</response>
        /// <response code="500">Baisi klaida!</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("Filter")]
        public ActionResult<List<GetBookDto>> Filter([FromQuery]FilterBooksRequestDto req)
        {
            _logger.LogInformation("HttpGet Filter(FilterBooksRequestDto req = {0}) buvo iskviestas {1} ", req, DateTime.Now);
            try
            {
                var books = _bookRepo.GetAll(b => b.Title.Contains(req.Pavadinimas != null ? req.Pavadinimas : "") &&
                                                  b.Author.Contains(req.Autorius != null ? req.Autorius : ""));

                var booksDto = new List<GetBookDto>();
                if (books != null)
                {
                    foreach (var book in books)
                    {
                        booksDto.Add(_wrapper.Bind(book));
                    }
                }
                return Ok(booksDto);
            }
            catch (Exception e)
            {
                _logger.LogError("HttpGet Filter(FilterBooksRequestDto req = {0}) nuluzo {1} ", req, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        /// <summary>
        /// Atnaujiname knyga, siusdami knygos objekta
        /// </summary>
        /// <param name="bookUpdated">Knykos objektas su visais atnaujintais laukais</param>
        /// <returns></returns>
        /// <response code="204">Sekmingai atnaujinta knyga</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateBook(UpdateBookDto bookUpdated)
        {
            _logger.LogInformation("HttpPut UpdateBook(bookUpdated = {0}) buvo iskvietas {1} ", JsonConvert.SerializeObject(bookUpdated), DateTime.Now);
            try
            {
                if (bookUpdated == null)
                {
                    _logger.LogError("HttpPut UpdateBook(bookUpdated) bookUpdated objektas == null {1} ", DateTime.Now);
                    return BadRequest();
                }

                Book book = _wrapper.Bind(bookUpdated);
                _bookRepo.Update(book);
                return NoContent();

            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpPut UpdateBook(bookUpdated = {0}) nuluzo {1} ", JsonConvert.SerializeObject(bookUpdated), DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        /// <summary>
        /// Trinama knyga is duomenu bases pagal specifini id
        /// </summary>
        /// <param name="id">Norimos istrinti knygos id</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="204">Sekmingai istrinta</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteBookById(int id)
        {
            _logger.LogInformation("HttpDelete DeleteBookById(id = {0}) buvo iskvietas {1} ", id, DateTime.Now);
            try
            {
                var book = _db.Books.FirstOrDefault(b => b.Id == id);
                if (book == null)
                {
                    _logger.LogError("HttpDelete DeleteBookById(id = {0}) knyga su tokiu id nerasta {1} ", id, DateTime.Now);
                    return NotFound();
                }

                _bookRepo.Remove(book);
                //_db.Books.Remove(book);
                //_db.SaveChanges();

                return NoContent();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpDelete DeleteBookById(id = {0}) nuluzo {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
