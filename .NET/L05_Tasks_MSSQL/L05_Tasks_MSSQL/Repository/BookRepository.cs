using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Repository.IRepository;

namespace L05_Tasks_MSSQL.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly BookStoreContext _db;

        public BookRepository(BookStoreContext db) : base(db)
        {
            _db = db;
        }

        public Book Update(Book book)
        {
            book.Updated = DateTime.Now;
            _db.Books.Update(book);
            _db.SaveChanges();

            return book;
        }
    }
}
