using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;

namespace L04_EF_Applying_To_API.Services.Adapters.IAdapters
{
    public interface IDishAdapter
    {
        UpdateDishDto Bind(Dish dish);
        Dish Bind(UpdateDishDto updateDishDto, int id);

    }
}
