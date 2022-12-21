using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using L04_EF_Applying_To_API.Services.Adapters.IAdapters;

namespace L04_EF_Applying_To_API.Services.Adapters
{
    public class DishAdapter : IDishAdapter
    {
        public UpdateDishDto Bind(Dish dish)
        {
            return new UpdateDishDto()
            {
                Name = dish.Name,
                Country = dish.Country,
                ImagePath = dish.ImagePath,
                SpiceLevel = dish.SpiceLevel,
                Type = dish.Type
            };
        }

        public Dish Bind(UpdateDishDto updateDishDto, int id)
        {
            return new Dish()
            {
                DishId = id,
                Name = updateDishDto.Name,
                Country = updateDishDto.Country,
                ImagePath = updateDishDto.ImagePath,
                SpiceLevel = updateDishDto.SpiceLevel,
                Type = updateDishDto.Type
            };
        }
    }
}
