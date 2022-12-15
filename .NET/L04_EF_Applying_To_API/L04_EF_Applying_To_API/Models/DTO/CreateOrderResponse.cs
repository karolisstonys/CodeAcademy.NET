namespace L04_EF_Applying_To_API.Models.DTO
{
    public class CreateOrderResponse
    {
        public string DishName { get; set; }
        public string State { get; set; }
        public DateTime CookingFinishedDateTime { get; set; }

    }
}
