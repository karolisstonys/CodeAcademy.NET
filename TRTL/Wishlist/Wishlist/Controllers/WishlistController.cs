using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wishlist.Data;
using Wishlist.Models;
using Wishlist.Models.Dto;
using Wishlist.Services.Interfaces;

namespace Wishlist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly WishlistContext _db;
        private readonly IGuidService _guid;
        private readonly IPasswordService _pass;

        public WishlistController(WishlistContext db, IGuidService guid, IPasswordService pass)
        {
            _db = db;
            _guid = guid;
            _pass = pass;
        }












    }
}
