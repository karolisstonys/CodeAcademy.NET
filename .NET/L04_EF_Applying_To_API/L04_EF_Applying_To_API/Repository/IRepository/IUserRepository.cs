using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;

namespace L04_EF_Applying_To_API.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<bool> IsUniqueUserAsync(string username);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest registrationRequest);
    }
}
