using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using L05_Tasks_MSSQL.Services.IServices;

namespace L05_Tasks_MSSQL.Services
{
    public class UserAdapter : IUserAdapter
    {
        public GetUserDto Bind(User user)
        {
            return new GetUserDto()
            {
                UserId = user.Id,
                FullName = user.FullName,
                Role = user.Role,
                TakenLibraryBooks = user.TakenLibraryBooks,
                BooksNotReturnedInTime = user.BooksNotReturnedInTime,
                TotalDebt = user.TotalDebt,
                LastLogin = user.LastLogin,
                Points = user.Points
            };
        }
    }
}
