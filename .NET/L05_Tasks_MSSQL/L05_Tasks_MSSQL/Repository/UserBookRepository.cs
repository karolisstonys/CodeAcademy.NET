using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Repository.IRepository;

namespace L05_Tasks_MSSQL.Repository
{
    public class UserBookRepository : Repository<UserBook>, IUserBookRepository
    {
        private readonly BookStoreContext _db;

        public UserBookRepository(BookStoreContext db): base(db)
        {
            _db = db;
        }

        public UserBook Update(UserBook userBook)
        {
            userBook.Updated = DateTime.Now;
            _db.UserBooks.Update(userBook);
            _db.SaveChanges();
            return userBook;
        }
    }
}
