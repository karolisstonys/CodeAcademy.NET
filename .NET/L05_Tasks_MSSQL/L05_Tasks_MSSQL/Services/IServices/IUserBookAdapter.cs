using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;

namespace L05_Tasks_MSSQL.Services.IServices
{
    public interface IUserBookAdapter
    {
        public UserBook Adapt(User user, LibraryBook libraryBook);
        public GetUserBookDto Adapt(UserBook userBook);
    }
}
