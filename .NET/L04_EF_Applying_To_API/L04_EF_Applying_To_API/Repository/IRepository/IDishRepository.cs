using L04_EF_Applying_To_API.Models;

namespace L04_EF_Applying_To_API.Repository.IRepository
{
    public interface IDishRepository : IRepository<Dish>
    {
        Task<Dish> UpdateAsync(Dish dish);
    }
}
