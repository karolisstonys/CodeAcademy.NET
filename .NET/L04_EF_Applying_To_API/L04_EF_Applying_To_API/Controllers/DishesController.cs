﻿using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using L04_EF_Applying_To_API.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L04_EF_Applying_To_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepo;

        public DishesController(IDishRepository dishRepo)
        {
            _dishRepo = dishRepo;
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
            return Ok(_dishRepo.GetAll()
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

            var dish = _dishRepo.Get(d => d.DishId == id);
            if (dish == null) return BadRequest();

            return Ok(new GetDishDto(dish));
        }

        /// <summary>
        /// Creates new dish
        /// </summary>
        /// <param name="createDishDto">Dish object</param>
        /// <returns></returns>
        [Authorize]
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

            _dishRepo.Create(newDish);

            return CreatedAtRoute("GetDish", new { id = newDish.DishId }, createDishDto);
        }

        /// <summary>
        /// Deletes specific dish
        /// </summary>
        /// <param name="id">Id by which dish object is deleted</param>
        /// <returns></returns>
        [HttpDelete("delete/{id:int}")]
        [Authorize(Roles = "super-admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteDishById(int id)
        {
            if (id == 0) return BadRequest();

            var dish = _dishRepo.Get(d => d.DishId == id);
            if (dish == null) return BadRequest();

            _dishRepo.Remove(dish);

            return NoContent();
        }


        /// <summary>
        /// Updates specific dish
        /// </summary>
        /// <param name="id">Id by which dish object is updated</param>
        /// <returns></returns>
        [HttpPut("update/{id:int}")]
        [Authorize(Roles = "admin,")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateDishById(int id, UpdateDishDto updateDishDto)
        {
            if (id == 0 || updateDishDto == null) return BadRequest();

            var foundDish = _dishRepo.Get(d => d.DishId == id);
            if (foundDish == null) return BadRequest();

            foundDish.Name = updateDishDto.Name;
            foundDish.Type = updateDishDto.Type;
            foundDish.SpiceLevel = updateDishDto.SpiceLevel;
            foundDish.Country = updateDishDto.Country;
            foundDish.ImagePath = updateDishDto.ImagePath;


            _dishRepo.Update(foundDish);

            return NoContent();

        }




    }
}
