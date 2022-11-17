using L02_Rest_Endpoints.Data;
using L02_Rest_Endpoints.Models;
using L02_Rest_Endpoints.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L02_Rest_Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        [HttpGet("allfood")]
        public IEnumerable<FoodDTO> GetAllFood()
        {
            var allfood = FoodStore.foodList;
            return allfood;
        }

        [HttpGet("foods/{id:int}")]
        public FoodDTO? GetFoodById(int id)
        {
            return FoodStore.foodList
                .FirstOrDefault(f => f.Id == id);
        }


    }
}
