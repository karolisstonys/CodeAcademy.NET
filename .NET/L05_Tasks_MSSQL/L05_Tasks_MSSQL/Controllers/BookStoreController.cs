using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {

        private readonly BookStoreContext _db;

        public BookStoreController(BookStoreContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Fetches all authors in the DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("AllAuthors")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetAuthorDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetAuthorDto>> GetAuthors()
        {
            return Ok(_db.Authors
                .Select(a => new GetAuthorDto(a))
                .ToList());
        }

        /// <summary>
        /// Fetch author with a specified ID from DB
        /// </summary>
        /// <param name="id">Requested autor ID</param>
        /// <returns></returns>
        [HttpGet("GetSingleAuthor/{id:int}", Name = "GetAuthor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetAuthorDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetAuthorDto> GetAuthorById(int id)
        {
            if (id == 0) return BadRequest();

            var autor = _db.Authors.FirstOrDefault(a => a.Id == id);
            if (autor == null) return BadRequest();

            return Ok(new GetAuthorDto(autor));
        }


        /// <summary>
        /// Creates new author
        /// </summary>
        /// <param name="createDishDto">Author object</param>
        /// <returns></returns>
        [HttpPost("CreateAuthor")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateAuthorDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateAuthorDto> CreateAuthor(CreateAuthorDto createAuthorDto)
        {
            if (createAuthorDto == null) return BadRequest();

            Author newAuthor = new Author()
            {
                Name = createAuthorDto.Name
            };

            _db.Authors.Add(newAuthor);
            _db.SaveChanges();

            //return Created("", createDishDto);
            return CreatedAtRoute("GetAuthor", new { id = newAuthor.Id }, createAuthorDto);
        }


    }
}
