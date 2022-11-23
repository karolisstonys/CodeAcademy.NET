using L04_EF_Applying_To_API.Models;
using Microsoft.EntityFrameworkCore;

namespace L04_EF_Applying_To_API.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<RecipeItem> RecipeItems { get; set; }
    }
}
