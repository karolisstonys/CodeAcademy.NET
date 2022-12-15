using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using L04_EF_Applying_To_API.Services.Adapters.IAdapters;

namespace L04_EF_Applying_To_API.Services.Adapters
{
    public class DishOrderAdapter : IDishOrderAdapter
    {
        public GetOrderResponse Bind(DishOrder dishOrder)
        {
            return new GetOrderResponse()
            {
                Dish = dishOrder.Dish,
                User = dishOrder.LocalUser
            };
        }

        public DishOrder Bind(CreateOrderRequest req)
        {
            return new DishOrder()
            {
                DishId = req.DishId,
                LocalUserId = req.UserId
            };
        }

        public CreateOrderResponse Bind(Dish dish)
        {
            return new CreateOrderResponse()
            {
                DishName = dish.Name,
                CookingFinishedDateTime = DateTime.Now.AddSeconds(30),
                State = "Cooking..."
            };
        }
    }
}
