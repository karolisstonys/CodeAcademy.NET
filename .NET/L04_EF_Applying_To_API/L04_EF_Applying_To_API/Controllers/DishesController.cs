using L04_EF_Applying_To_API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L04_EF_Applying_To_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        [HttpGet("Dishes")]
        public ActionResult<IEnumerable<GetDishDto>> GetDishes()
        {
            return NotFound();
        }


    }
}
