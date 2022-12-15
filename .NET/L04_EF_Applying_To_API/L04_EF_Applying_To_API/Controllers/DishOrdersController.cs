using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using L04_EF_Applying_To_API.Repository.IRepository;
using L04_EF_Applying_To_API.Services.Adapters.IAdapters;
using L04_EF_Applying_To_API.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace L04_EF_Applying_To_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishOrdersController : ControllerBase
    {
        private readonly IDishOrderRepository _dishOrderRepo;
        private readonly IUserRepository _userRepo;
        private readonly IDishRepository _dishRepo;
        private readonly IDishOrderAdapter _dishOrderAdapter;
        private readonly ICookingService _cookingService;

        public DishOrdersController(IDishOrderRepository dishOrderRepo, 
                                    IUserRepository userRepo, 
                                    IDishRepository dishRepo, 
                                    IDishOrderAdapter dishOrderAdapter,
                                    ICookingService cookingService)
        {
            _dishOrderRepo = dishOrderRepo;
            _userRepo=userRepo;
            _dishRepo = dishRepo;
            _dishOrderAdapter = dishOrderAdapter;
            _cookingService = cookingService;
        }

        [HttpGet("DishOrder")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetOrderResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetOrderResponse>> GetDishOrderById([FromQuery] GetOrderRequest req)
        {
            if (req.UserId == 0 || req.DishId == 0) return BadRequest();

            var isDishOrdered = await _dishOrderRepo.ExistsAsync(o => o.LocalUserId == req.UserId && o.DishId == req.DishId);
            if (isDishOrdered) return BadRequest();
            
            var dishOrder = await _dishOrderRepo.GetAsync(o => o.LocalUserId == req.UserId && o.DishId == req.DishId);

            return Ok(_dishOrderAdapter.Bind(dishOrder));
        }


        [HttpPost("CreateDishOrder")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateDishDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<CreateOrderResponse>> CreateDishOrder(CreateOrderRequest req)
        {
            if (req == null || req.DishId == 0 || req.UserId == 0) return BadRequest();

            var isRegistered = await _userRepo.IsRegisteredAsync(req.UserId);
            if (isRegistered) return NotFound();

            var dishExists = await _dishRepo.ExistsAsync(d => d.DishId == req.DishId);
            if (isRegistered) return NotFound();

            var orderedDish = await _dishOrderRepo.GetAsync(d => d.DishId == req.DishId);

            var newDishOrder = _dishOrderAdapter.Bind(req);
            var response = _dishOrderAdapter.Bind(orderedDish);

            await _dishOrderRepo.CreateAsync(newDishOrder);

            await _cookingService.CookAsync(newDishOrder);

            return CreatedAtAction(nameof(GetDishOrderById), new { id = newDishOrder.DishId }, response);
        }
    }
}
