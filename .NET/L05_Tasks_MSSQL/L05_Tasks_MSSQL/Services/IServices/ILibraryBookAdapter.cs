using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;

namespace L05_Tasks_MSSQL.Services.IServices
{
    public interface ILibraryBookAdapter
    {
        GetLibraryBookDto Adapt(LibraryBook libraryBook);
        List<GetLibraryBookDto> Adapt(IEnumerable<LibraryBook> libraryBooks);
    }
}
