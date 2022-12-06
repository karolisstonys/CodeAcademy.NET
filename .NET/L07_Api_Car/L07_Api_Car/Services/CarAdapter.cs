using L07_Api_Car.Models;
using L07_Api_Car.Models.Dto;
using L07_Api_Car.Models.Enums;

namespace L07_Api_Car.Services
{
    public class CarAdapter : ICarAdapter
    {
        public GetCarResult Bind(Car car)
        {
            return new GetCarResult
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                Year = car.Year.ToString("yyyy-MM-dd"),
                PlateNumber = car.PlateNumber ?? "neregistruota",
                GearBox = car.GearBox.ToString(),
                Fuel = car.Fuel.ToString()
            };
        }

        public Car Bind(PostCarRequest car)
        {
            return new Car
            {
                Make = car.Make,
                Model = car.Model,
                Year = DateTime.Parse(car.Year),
                PlateNumber = car.PlateNumber,
                GearBox = (ECarGearBox)Enum.Parse(typeof(ECarGearBox), car.GearBox),
                Fuel = (ECarFuel)Enum.Parse(typeof(ECarFuel), car.Fuel)
            };
        }
    }
}
