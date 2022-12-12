using L07_Api_Car.Repository;

namespace L07_Api_Car.Services
{
    public class CarLeasingService : ICarLeasingService
    {
        private readonly ICarRepository _repo;

        public CarLeasingService(ICarRepository repo)
        {
            _repo = repo;
        }

        public decimal AddPrive(double price, double percent)
        {
            return (decimal)(price * ( 1 + percent / 100 ));
        }

        public bool CanLease(int carId)
        {
            throw new NotImplementedException();
        }

        public void ChangeYear(int carId, int year)
        {
            var car = _repo.Get(carId);
            // kazkokia logika ...
            car.Year = new DateTime(year, 1, 1);
            _repo.Update(car);
        }


    }
}
