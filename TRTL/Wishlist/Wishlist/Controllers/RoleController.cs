using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wishlist.Data;
using Wishlist.Models.Dto;

namespace Wishlist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly WishlistContext _db;

        public RoleController(WishlistContext db)
        {
            _db = db;
        }


        //[HttpGet("GetAllRoles")]
        //public List<GetRolesDto> GetAllRoles()
        //{
        //    var allRoles = new List<GetRolesDto>();

        //    foreach (var role in _db.Roles)
        //    {
        //        allRoles.Add(new GetRolesDto(role));
        //    }

        //    return allRoles;
        //}
    }
}
