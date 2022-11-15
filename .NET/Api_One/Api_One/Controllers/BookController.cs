using Api_One.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_One.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> allBooks = new List<Book>()
        {
            new Book { Id = 1, Title = "Knyga1", Author = "Autorius1", ReleaseYear = 2001 },
            new Book { Id = 2, Title = "Knyga2", Author = "Autorius2", ReleaseYear = 2002 },
            new Book { Id = 3, Title = "Knyga3", Author = "Autorius3", ReleaseYear = 2003 },
            new Book { Id = 4, Title = "Knyga4", Author = "Autorius4", ReleaseYear = 2004 },
            new Book { Id = 5, Title = "Knyga5", Author = "Autorius5", ReleaseYear = 2005 },
            new Book { Id = 6, Title = "Knyga6", Author = "Autorius6", ReleaseYear = 2006 },
            new Book { Id = 7, Title = "Knyga7", Author = "Autorius7", ReleaseYear = 2007 },
            new Book { Id = 8, Title = "Knyga8", Author = "Autorius8", ReleaseYear = 2008 },
            new Book { Id = 9, Title = "Knyga9", Author = "Autorius9", ReleaseYear = 2009 }
        };

        [HttpGet("RandomBook")]
        public Book GetMeAnyBook()
        {
            var anyBook = allBooks[Random.Shared.Next(allBooks.Count)];
            return anyBook;
        }

        [HttpGet("{id}")]
        public Book GetMeABook(int id)
        {
            return allBooks.FirstOrDefault(b => b.Id == id);
        }

        [HttpGet("Search1")]
        public Book GetMeABookById(int id)
        {
            return allBooks.FirstOrDefault(b => b.Id == id);
        }

        [HttpGet("Search2")]
        public IEnumerable<Book> GetMeAllBooksByTitle(string title)
        {
             var a = from book in allBooks
                   where book.Title.Contains(title)
                   select book;
            return a;
        }
    }
}
