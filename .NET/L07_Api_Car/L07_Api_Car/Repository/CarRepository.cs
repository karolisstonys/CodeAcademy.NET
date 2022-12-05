using L07_Api_Car.Data;
using L07_Api_Car.Models;
using System.Linq.Expressions;

namespace L07_Api_Car.Repository
{
    public class CarRepository : IRepository<Car>
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context)
        {
            _context=context;
        }

        public IEnumerable<Car> All() => _context.Cars;

        public Car Get(int id) => _context.Cars.First(c => c.Id == id);

        public IEnumerable<Car> Find(Expression<Func<Car, bool>> filter) => _context.Cars.Where(filter);

        public int Count() => _context.Cars.Count();

        public int Create(Car entity)
        {
            _context.Cars.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public void Delete(Car entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public bool Exists(int id) => _context.Cars.Any(c => c.Id == id);


        public void Update(Car entity)
        {
            _context.Cars.Update(entity);
            _context.SaveChanges();
        }
    }
}
