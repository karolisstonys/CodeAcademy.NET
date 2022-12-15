using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Repository.IRepository;

namespace L04_EF_Applying_To_API.Repository
{
    public class DishOrderRepository : Repository<DishOrder>, IDishOrderRepository
    {
        private readonly RestaurantContext _db;

        public DishOrderRepository(RestaurantContext db) : base(db)
        {
            _db = db;
        }
    }
}
