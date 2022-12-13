using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.HelperDto;
using L05_Tasks_MSSQL.Models.DTO.UserDto;

namespace L05_Tasks_MSSQL.Helpers.IHelpers
{
    public interface ILibraryHelper
    {
        BoolAndMsgDto CanThisBookBeTaken(LibraryBook book);
        BoolAndMsgDto CanThisUserTakeABook(GetUserDto user);
    }
}
