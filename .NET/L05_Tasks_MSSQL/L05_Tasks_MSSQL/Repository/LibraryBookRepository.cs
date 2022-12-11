using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Repository.IRepository;
using System.Linq.Expressions;

namespace L05_Tasks_MSSQL.Repository
{
    public class LibraryBookRepository : Repository<LibraryBook>, ILibraryBookRepository
    {
        private readonly BookStoreContext _db;

        public LibraryBookRepository(BookStoreContext db) : base(db)
        {
            _db = db;
        }

        public LibraryBook Update(LibraryBook libraryBook)
        {
            libraryBook.Updated = DateTime.Now;
            _db.LibraryBooks.Update(libraryBook);
            _db.SaveChanges();
            return libraryBook;
        }



    }
}
