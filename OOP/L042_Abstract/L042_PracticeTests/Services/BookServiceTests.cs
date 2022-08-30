using Microsoft.VisualStudio.TestTools.UnitTesting;
using L042_Practice.Models.Abstract;
using L042_Practice.Models.Concrete;

namespace L042_Practice.Services.Tests
{
    [TestClass()]
    public class BookServiceTests
    {
        [TestMethod()]
        public void EncodeTest()
        {

            List<Book> fake = new List<Book>()
            {
                new EBook { Genre = "Fantasy", Title = "Harry Potter 1", Author = "JR Rowling", BooksSold = 1200000, Qtty = 5, Price = 4},
                new AudioBook { Genre = "Fantasy", Title = "Harry Potter 1", Author = "JR Rowling", BooksSold = 12000, Qtty = 0, Price = 20},
                new PaperBackBook { Genre = "Fantasy", Title = "Harry Potter 1", Author = "JR Rowling", BooksSold = 81200000, Qtty = 14, Price = 10},
                new HardCoverBook { Genre = "Fantasy", Title = "Harry Potter 1", Author = "JR Rowling", BooksSold = 90200000, Qtty = 2, Price = 22},
                new PaperBackBook { Genre = "Mystery", Title = "The Da Vinchi Code", Author = "Who Knows", BooksSold = 10000000, Qtty = 1, Price = 25},
            };

            BookService service = new BookService();
            string actual = service.Encode(fake);

            var decoded = service.Decode(actual);
            Assert.AreEqual(4, decoded.Count);
        }
    }
}