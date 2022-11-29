using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {

        private readonly BookStoreContext _db;
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<BookStoreController> _logger;

        public BookStoreController(BookStoreContext db, IBookWrapper wrapper, ILogger<BookStoreController> logger)
        {
            _db = db;
            _wrapper = wrapper;
            _logger = logger;
        }

        /// <summary>
        /// Uklausia visu knygu is duomenu bazes
        /// </summary>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma visos knygos</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("AllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetBookDto>> GetBooks()
        {
            _logger.LogInformation("Get AllBooks() buvo iskvietas {0} ", DateTime.Now);
            try
            {
                return Ok(_db.Books
                    .Select(book => _wrapper.Bind(book))
                    .ToList());
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Get AllBooks() nuluzo {0}", DateTime.Now);
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
        public ActionResult<GetBookDto> GetBookById(int id)
        {


            _logger.LogInformation("Get GetBookById(id = {0}) buvo iskvietas {1} ", id, DateTime.Now);
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Get GetBookById(id = {0}) su blogu id {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                var book = _db.Books.FirstOrDefault(a => a.Id == id);
                if (book == null)
                {
                    _logger.LogError("Get GetBookById(id = {0}) knyga su tokiu id nerasta {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                return Ok(_wrapper.Bind(book));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Get GetBookById(id = {0}) nuluzo {1} ", id, DateTime.Now);
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
        public ActionResult<CreateBookDto> CreateBook(CreateBookDto createBookDto)
        {
            if (createBookDto == null) return BadRequest();

            Book newBook = _wrapper.Bind(createBookDto);

            _db.Books.Add(newBook);
            _db.SaveChanges();

            return CreatedAtRoute("GetBook", new { id = newBook.Id }, createBookDto);
        }



        //[HttpGet("Filter")]
        //public ActionResult<List<GetBookDto>> Filter(FilterBooksRequestDto req)
        //{
        //    throw new NotImplementedException();
        //}


        //[HttpPut]
        //public IActionResult Put(UpdateBookDto req)
        //{
        //    throw new NotImplementedException();
        //}


        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
