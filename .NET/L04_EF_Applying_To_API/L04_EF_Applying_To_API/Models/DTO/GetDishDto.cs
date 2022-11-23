namespace L04_EF_Applying_To_API.Models.DTO
{
    public class GetDishDto
    {
        public GetDishDto(Dish dish)
        {
            Name = dish.Name;
            Type = dish.Type;
            SpiceLevel = dish.SpiceLevel;
            Country = dish.Country;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
    }
}
