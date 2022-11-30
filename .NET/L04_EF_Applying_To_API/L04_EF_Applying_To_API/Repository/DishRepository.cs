using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Repository.IRepository;

namespace L04_EF_Applying_To_API.Repository
{
    public class DishRepository : Repository<Dish>, IDishRepository
    {
        private readonly RestaurantContext _db;

        public DishRepository(RestaurantContext db) : base(db)
        {
            _db = db;
        }

        public Dish Update(Dish dish)
        {
            dish.UpdatedDateTime = DateTime.Now;
            _db.Dishes.Update(dish);
            _db.SaveChanges();
            return dish;
        }
    }
}
