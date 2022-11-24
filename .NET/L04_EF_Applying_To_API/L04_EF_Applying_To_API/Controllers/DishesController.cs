using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        /// <summary>
        /// Fetches all registered dishes in the DB
        /// </summary>
        /// <returns>All dishes in DB</returns>
        [HttpGet("AllDishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetDishDto>> GetDishes()
        {
            return Ok(_db.Dishes
                .Include(d => d.RecipeItems)
                .Select(d => new GetDishDto(d))
                .ToList());
        }

        /// <summary>
        /// Fetch registered dish with a specified ID from DB
        /// </summary>
        /// <param name="id">Requested dish ID</param>
        /// <returns>Dish with specified ID</returns>
        [HttpGet("{id:int}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetDishDto> GetDishById(int id)
        {
            if (id == 0) return BadRequest();

            var dish = _db.Dishes
                .Include(d => d.RecipeItems)
                .FirstOrDefault(d => d.DishId == id);
            if (dish == null) return BadRequest();

            return Ok(new GetDishDto(dish));
        }


        [HttpPost("CreateDish")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateDishDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateDishDto> CreateDish(CreateDishDto createDishDto)
        {
            if (createDishDto == null) return BadRequest();

            Dish newDish = new Dish()
            {
                Country = createDishDto.Country,
                SpiceLevel = createDishDto.SpiceLevel,
                Type = createDishDto.Type,
                Name = createDishDto.Name,
                CreatedDateTime = createDishDto.CreatedDateTime,
                ImagePath = createDishDto.ImagePath
            };

            _db.Dishes.Add(newDish);
            _db.SaveChanges();

            return CreatedAtRoute("GetDish", new { id = newDish.DishId }, createDishDto);
        }


        [HttpDelete("delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteDishById(int id)
        {
            if (id == 0) return BadRequest();

            var dish = _db.Dishes.FirstOrDefault(d => d.DishId == id);
            if (dish == null) return BadRequest();

            _db.Dishes.Remove(dish);
            _db.SaveChanges();

            return NoContent();
        }


        [HttpPut("update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateDishById(int id, UpdateDishDto updateDishDto)
        {
            if (id == 0 || updateDishDto == null) return BadRequest();

            var foundDish = _db.Dishes.FirstOrDefault(d => d.DishId == id);
            if (foundDish == null) return BadRequest();

            foundDish.Name = updateDishDto.Name;
            foundDish.Type = updateDishDto.Type;
            foundDish.SpiceLevel = updateDishDto.SpiceLevel;
            foundDish.Country = updateDishDto.Country;
            foundDish.ImagePath = updateDishDto.ImagePath;


            _db.Dishes.Update(foundDish);
            _db.SaveChanges();

            return NoContent();

        }




    }
}
