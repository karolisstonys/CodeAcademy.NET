using L02_Task_1.Data;
using L02_Task_1.Models;
using L02_Task_1.Models.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace L02_Rest_Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        [HttpGet("allfood")]
        [EnableCors("corsforfood")]
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

        [ApiExplorerSettings(IgnoreApi = true)]     // paslepia action (swaggeryje)
        [HttpGet("foods/testin/{id:int}")]
        public FoodDTO? GetFoodByIdTesting(int id)
        {
            return FoodStore.foodList
                .FirstOrDefault(f => f.Id == id);
        }

        [HttpGet("foods/country")]
        public FoodDTO? GetFoodByNameAndCountry(string foodName, string foodCountry)
        {
            return FoodStore.foodList
                .FirstOrDefault(f => f.Name == foodName && f.Country == foodCountry);
        }

        [HttpPost]
        public FoodDTO? CreateFood(FoodDTO foodDTO)
        {
            int getLargestFoodStoreId = FoodStore.foodList  // galima ir .Max(f => f.id);
                .OrderByDescending(f => f.Id)
                .First().Id;

            foodDTO.Id = getLargestFoodStoreId + 1;

            FoodStore.foodList.Add(foodDTO);

            return foodDTO;
        }

        [HttpDelete("foods/delete/{id:int}")]
        public void DeleteFood(int id)
        {
            var food = FoodStore.foodList
                .FirstOrDefault(f => f.Id == id);
            FoodStore.foodList.Remove(food);
        }

        [HttpPut("foods/put/{id:int}")]
        public List<FoodDTO>? UpdateFood(int id, FoodDTO foodDTO)
        {
            var oldFood = new FoodDTO()     // priskiriame naujam var dar nepakeista objekta    // NEVEIKIA     // REF TYPE !!!
            {
                Id = foodDTO.Id,
                Name = foodDTO.Name.ToString(),
                Country = foodDTO.Country.ToString(),
            };

            var food = FoodStore.foodList     // surandame objekta kuri keisime ir pakeiciame kas ateina PUT BODY'je
                .FirstOrDefault(f => f.Id == id);
            food.Name = foodDTO.Name;
            food.Weight = foodDTO.Weight;
            food.Country = foodDTO.Country;

            var oldAndUpdated = new List<FoodDTO>();    // pridedam i LIST<FoodDTO> abu objektus nepakeista ir pakeista
            oldAndUpdated.Add(oldFood);
            oldAndUpdated.Add(food);

            return oldAndUpdated;
        }
    }
}
