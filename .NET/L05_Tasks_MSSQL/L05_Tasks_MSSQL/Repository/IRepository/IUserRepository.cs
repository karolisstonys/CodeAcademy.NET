using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using System.Linq.Expressions;

namespace L05_Tasks_MSSQL.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        RegistrationResponse Register(RegistrationRequest registrationRequest);
        List<GetUserDto> GetAll(Expression<Func<User, bool>>? filter = null);
        GetUserDto Get(Expression<Func<User, bool>> filter = null);
        void UpdateTakenLibraryBooks(int userId, int modifier);
        void UpdateBooksNotReturnedInTimeAndTotalDebt(int userId, int booksNotReturnedInTime, double totalDebt);
        Task Update(GetUserDto userDto);
    }
}
