using L04_EF_Applying_To_API.Models;

namespace L04_EF_Applying_To_API.Services.IServices
{
    public interface ICookingService
    {
        Task CookAsync(DishOrder dishOrder);
    }
}
