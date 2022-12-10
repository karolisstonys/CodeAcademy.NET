using L05_Tasks_MSSQL.Models;

namespace L05_Tasks_MSSQL.Repository.IRepository
{
    public interface ILibraryBookRepository : IRepository<LibraryBook>
    {
        LibraryBook Update(LibraryBook libraryBook);
    }
}
