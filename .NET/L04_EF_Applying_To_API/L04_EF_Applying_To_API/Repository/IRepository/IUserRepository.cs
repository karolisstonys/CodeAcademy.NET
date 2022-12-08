using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;

namespace L04_EF_Applying_To_API.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);

        LoginResponse Login(LoginRequest loginRequest);

        RegistrationResponse Register(RegistrationRequest registrationRequest);
    }
}
