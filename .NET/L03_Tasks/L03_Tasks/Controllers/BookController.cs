using L03_Tasks.Data;
using L03_Tasks.Models;
using L03_Tasks.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L03_Tasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly IBookSet _mySet;

        //public BookController(IBookSet mySet)
        //{
        //    _mySet = mySet;
        //}

        //[HttpGet("all")]
        //public List<Book> GetAllBooks()
        //{
        //    return _mySet.Books;
        //}

        //[HttpGet("{id}")]
        //public Book? GetBookById(int id)
        //{
        //    return _mySet.Books.Where(b => b.Id == id).FirstOrDefault();
        //}

        [HttpGet]
        public ActionResult<List<GetBookDto>> Get()
        {
            throw new NotImplementedException();
        }


        [HttpGet("{id}")]
        public ActionResult<GetBookDto> Get(int id)
        {
            throw new NotImplementedException();
        }


        [HttpGet("Filter")]
        public ActionResult<List<GetBookDto>> Filter(FilterBooksRequestDto req)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        public IActionResult Post(CreateBookDto req)
        {
            throw new NotImplementedException();
        }


        [HttpPut]
        public IActionResult Put(UpdateBookDto req)
        {
            throw new NotImplementedException();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
