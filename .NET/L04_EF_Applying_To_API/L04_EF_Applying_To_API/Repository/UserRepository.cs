using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using L04_EF_Applying_To_API.Repository.IRepository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace L04_EF_Applying_To_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantContext _db;
        private string _secretKey;

        public UserRepository(RestaurantContext db, IConfiguration conf)
        {
            _db = db;
            _secretKey = conf.GetValue<string>("ApiSettings:SuperDuperSecret");
        }

        public bool IsUniqueUser(string username) => !_db.LocalUsers.Any(u => u.Username == username);

        public LoginResponse Login(LoginRequest loginRequest)
        {
            var user = _db.LocalUsers.FirstOrDefault(u => u.Username.ToLower() == loginRequest.Username.ToLower() &&
                                                          u.Password == loginRequest.Password);
            if (user == null)
                return new LoginResponse
                {
                    Token = "",
                    User = null
                };

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            LoginResponse loginResponse = new()
            {
                Token = tokenHandler.WriteToken(token),
                User = user
            };

            loginResponse.User.Password = "";

            return loginResponse;
        }

        public LocalUser Register(RegistrationRequest registrationRequest)
        {
            LocalUser user = new()
            {
                Username = registrationRequest.Username,
                Password = registrationRequest.Password,
                Name = registrationRequest.Name
            };

            _db.LocalUsers.Add(user);
            _db.SaveChanges();
            user.Password = "";

            return user;
        }
    }
}
