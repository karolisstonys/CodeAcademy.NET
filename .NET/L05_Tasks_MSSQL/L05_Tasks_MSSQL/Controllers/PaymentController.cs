using L05_Tasks_MSSQL.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public PaymentController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet("GetUserPoints")]
        public async Task<ActionResult<long>> GetUserPoints([FromQuery] int userId)
        {
            var user = _userRepo.Get(u => u.Id == userId);
            return user.Points;
        }

    }
}
