﻿namespace L04_EF_Applying_To_API.Models
{
    public class RecipeItem
    {
        public RecipeItem() { }

        public RecipeItem(int recipeItemId, string name, double calories, int dishId)
        {
            RecipeItemId=recipeItemId;
            Name=name;
            Calories=calories;
            DishId=dishId;
        }

        public int RecipeItemId { get; set; }

        public string Name { get; set; }

        public double Calories { get; set; }

        public int DishId { get; set; }

        public virtual Dish Dish { get; set; }

    }
}
