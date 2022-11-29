using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wishlist.Data;
using Wishlist.Models;
using Wishlist.Models.Dto;
using Wishlist.Models.Enums;
using Wishlist.Services.Interfaces;

namespace Wishlist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly WishlistContext _db;
        private readonly IGuidService _guid;
        private readonly IPasswordService _pass;

        public UserController(WishlistContext db, IGuidService guid, IPasswordService pass)
        {
            _db = db;
            _guid = guid;
            _pass = pass;
        }


        [HttpGet("GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetUserDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<GetUserDto>> GetAllUsers()
        {
            var allUsers = new List<GetUserDto>();

            foreach (var user in _db.Users)
            {
                allUsers.Add(new GetUserDto(user));
            }

            return Ok(allUsers);
        }


        [HttpGet("GetUser/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateUserDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetUserDto> GetUser(int id)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null) return NotFound();

            return Ok(user);
        }


        [HttpPost("CreateUser")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateUserDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateUserDto> CreateUser(string username, string password)
        {
            var foundUser = _db.Users.FirstOrDefault(u => u.Username == username);
            if (foundUser != null) return BadRequest("Username already exists");

            User newUser = new User()
            {
                Username = username,
                Password = _pass.HashPassword(password),
                Guid = _guid.GetNewGuid(),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Role = ERole.User
            };

            _db.Users.Add(newUser);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, new CreateUserDto(newUser));
        }



    }
}
