using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;

namespace L04_EF_Applying_To_API.Services.Adapters.IAdapters
{
    public interface IDishOrderAdapter
    {
        GetOrderResponse Bind(DishOrder dishOrder);
        DishOrder Bind(CreateOrderRequest req);
        CreateOrderResponse Bind(Dish dish);
    }
}
