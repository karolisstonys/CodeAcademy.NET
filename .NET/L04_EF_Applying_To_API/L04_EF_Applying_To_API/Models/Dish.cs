namespace L04_EF_Applying_To_API.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        public DateTime  CreatedDateTime { get; set; }
        public List<RecipeItem> RecipeItems { get; set; }
    }
}
