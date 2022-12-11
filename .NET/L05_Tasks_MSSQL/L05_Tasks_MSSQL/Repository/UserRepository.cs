using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using System.Text;

namespace L05_Tasks_MSSQL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BookStoreContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;
        private readonly LoginResponse _emptyTokenAndNullUser = new LoginResponse
        {
            Token = "",
            User = null
        };

        public UserRepository(BookStoreContext db, IConfiguration conf, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService=jwtService;
        }

        public bool IsUniqueUser(string username) => !_db.Users.Any(u => u.Username == username);

        public LoginResponse Login(LoginRequest loginRequest)
        {
            var inputPastwordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = _db.Users.FirstOrDefault(u => u.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null) return _emptyTokenAndNullUser;

            if (!_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) return _emptyTokenAndNullUser;

            var token = _jwtService.GetJwtToken(user.Id, user.Role);

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = new RegistrationResponse()
                {
                    Id = user.Id,
                    Username = user.Username,
                    FullName = user.FullName,
                    Role = user.Role
                }
            };

            return loginResponse;
        }

        public RegistrationResponse Register(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] hash, out byte[] salt);

            User user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = hash,
                PasswordSalt = salt,
                FullName = registrationRequest.FullName,
                Role = registrationRequest.Role,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };

            RegistrationResponse registrationResponse = new()
            {
                Username = registrationRequest.Username,
                FullName = registrationRequest.FullName,
                Role = registrationRequest.Role
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return registrationResponse;
        }
    }
}
