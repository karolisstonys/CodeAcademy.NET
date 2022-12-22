using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.UserDto;

namespace L05_Tasks_MSSQL.Services.IServices
{
    public interface IUserAdapter
    {
        GetUserDto Bind(User user);
    }
}
