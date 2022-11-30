using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wishlist.Data;
using Wishlist.Models.Dto;
using Wishlist.Services.Interfaces;

namespace Wishlist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly WishlistContext _db;
        private readonly IGuidService _guid;
        private readonly IPasswordService _pass;

        public LoginController(WishlistContext db, IGuidService guid, IPasswordService pass)
        {
            _db = db;
            _guid = guid;
            _pass = pass;
        }

        [HttpGet("login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetUserDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<GetUserDto> Login(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return BadRequest("username or password is incorrect");

            if (!_pass.VerifyPassword(user.Password, password)) return Unauthorized();
            var dto = new GetUserDto(user);
            return Ok(dto);
        }
    }
}
