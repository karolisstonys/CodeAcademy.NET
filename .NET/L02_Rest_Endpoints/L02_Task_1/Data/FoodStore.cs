using L02_Task_1.Models.Dto;

namespace L02_Task_1.Data
{
    public static class FoodStore
    {
        public static List<FoodDTO> foodList = new List<FoodDTO>()
        {
            new FoodDTO(1, "Orange", "Spain", 7.5),
            new FoodDTO(2, "Apple", "Spain", 12),
            new FoodDTO(3, "Banana", "Africa", 4.75),
            new FoodDTO(4, "Margarita Pizza", "Italy", 0.5),
            new FoodDTO(5, "German Sausages", "Germany", 8),
            new FoodDTO(6, "Potatoes", "Lithuania", 10),
        };
    }
}