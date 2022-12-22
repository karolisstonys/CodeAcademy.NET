using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IPointsService _pointsService;

        public UserController(IUserRepository userRepo, IPointsService pointsService)
        {
            _userRepo = userRepo;
            _pointsService = pointsService;
        }

        /// <summary>
        /// Prisijungimas su username ir password
        /// </summary>
        /// <param name="model">modelis nesantis username ir password</param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            var loginResponse = _userRepo.Login(model);
            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { mesage = "Username or password is incorect" });
            }

            var lastLoginIsToday = _pointsService.WasLastLoginToday(loginResponse.User);
            if (!lastLoginIsToday) 
            {
                int numberOfPoints = await _pointsService.HowManyPointsToAdd();
                loginResponse.User.Points += numberOfPoints;
            }

            loginResponse.User.LastLogin = DateTime.Now;
            await _userRepo.Update(loginResponse.User);

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
