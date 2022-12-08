using L05_Tasks_MSSQL.Models.DTO;

namespace L05_Tasks_MSSQL.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);

        LoginResponse Login(LoginRequest loginRequest);

        RegistrationResponse Register(RegistrationRequest registrationRequest);
    }
}
