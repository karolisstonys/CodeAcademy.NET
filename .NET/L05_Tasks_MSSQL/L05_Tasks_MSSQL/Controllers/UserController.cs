using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        /// <summary>
        /// Prisijungimas su username ir password
        /// </summary>
        /// <param name="model">modelis nesantis username ir password</param>
        /// <returns></returns>
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest model)
        {
            var loginResponse = _userRepo.Login(model);
            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { mesage = "Username or password is incorect" });
            }
            return Ok(loginResponse);
        }

        /// <summary>
        /// Naujo vartotojo registracija
        /// </summary>
        /// <param name="model">modelis nesantis username, full name, password ir role</param>
        /// <returns></returns>
        [HttpPost("Redistration")]
        public IActionResult Register([FromBody] RegistrationRequest model)
        {

            if (!_userRepo.IsUniqueUser(model.Username))
            {
                return BadRequest(new { mesage = "Username already exists" });
            }

            var user = _userRepo.Register(model);
            if (user == null)
            {
                return BadRequest(new { mesage = "Registration failed" });
            }
            return Ok(user);
        }
    }
}
