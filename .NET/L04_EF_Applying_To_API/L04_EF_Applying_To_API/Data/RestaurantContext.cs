using L04_EF_Applying_To_API.Models;
using Microsoft.EntityFrameworkCore;

namespace L04_EF_Applying_To_API.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<RecipeItem> RecipeItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // data-seeding
            modelBuilder.Entity<Dish>()
                .HasData(
                new Dish(1,"Fried bread sticks", "Snacks", "Low", "Lithuania", "", DateTime.Now),
                new Dish(2,"Potatoe dumplings", "Main dish", "Low", "Lithuania", "", DateTime.Now),
                new Dish(3,"Kibinai", "Street food", "Low", "Lithuania", "", DateTime.Now)
                );
            modelBuilder.Entity<RecipeItem>()
                .HasData(
                new RecipeItem(1, "Bread", 120.0, 1),
                new RecipeItem(2, "Cheese", 50.0, 1),
                new RecipeItem(3, "Mayo", 200.0, 1),
                new RecipeItem(4, "Garlic", 14.0, 1),
                new RecipeItem(5, "Potatoes", 600.0, 2),
                new RecipeItem(6, "Meat", 420.0, 2),
                new RecipeItem(7, "Sour cream", 180.0, 2),
                new RecipeItem(8, "Dough", 120.0, 3),
                new RecipeItem(9, "Meat", 120.0, 3),
                new RecipeItem(10, "Salt", 120.0, 3)
                );
        }
    }
}
