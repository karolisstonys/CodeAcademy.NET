using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Services.IServices;
using Microsoft.Extensions.Logging;

namespace L04_EF_Applying_To_API.Services
{
    public class CookingService : ICookingService
    {
        private readonly ILogger<CookingService> _logger;

        public CookingService(ILogger<CookingService> logger)
        {
            _logger = logger;
        }

        public async Task CookAsync(DishOrder dishOrder)
        {
            CookDishAsync(5, dishOrder);
        }

        public async Task CookDishAsync(int cookingTimeInSeconds, DishOrder dishOrder)
        {
            for (int i = 0; i <= 100; i+= 20)
            {
                await Task.Delay(1000 * cookingTimeInSeconds);
                _logger.LogInformation($"Cooking <{dishOrder.Dish.DishId}.{dishOrder.Dish.Name}> in progress... {i}/100%");
            }
            _logger.LogInformation($"<{dishOrder.Dish.DishId}.{dishOrder.Dish.Name}> DONE COOKING!");
        }
    }
}
