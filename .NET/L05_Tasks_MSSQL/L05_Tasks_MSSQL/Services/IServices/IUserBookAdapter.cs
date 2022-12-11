using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.DTO.UserDto;

namespace L05_Tasks_MSSQL.Services.IServices
{
    public interface IUserBookAdapter
    {
        public UserBook Adapt(GetUserDto user, LibraryBook libraryBook);
        public GetUserBookDto Adapt(UserBook userBook);
    }
}
