using L05_Tasks_MSSQL.Models;

namespace L05_Tasks_MSSQL.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Book Update(Book book);
    }
}
