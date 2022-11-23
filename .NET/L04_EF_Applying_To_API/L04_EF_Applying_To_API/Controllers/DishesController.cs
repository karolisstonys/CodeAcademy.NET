using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L04_EF_Applying_To_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly RestaurantContext _db;

        public DishesController(RestaurantContext db)
        {
            _db = db;
        }

        [HttpGet("Dishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetDishDto>> GetDishes()
        {
            return Ok(_db.Dishes.Select(d => new GetDishDto(d)).ToList());
        }


    }
}
