using L07_Api_Car.Models;
using L07_Api_Car.Models.Enums;

namespace L07_Api_Car.Data.InitialData
{
    public class CarInitialData
    {
        public static class CarData
        {
            public static readonly Car[] DataSeed = new Car[]
            {
            new Car
                {
                Id = 1,
                    Make = "Make1",
                    Model = "Model1",
                    Year = DateTime.Now,
                    PlateNumber = "ABC001",
                    GearBox = ECarGearBox.Manual,
                    Fuel = ECarFuel.Pertol
                },
            new Car
                {
                Id = 2,
                    Make = "Make2",
                    Model = "Model2",
                    Year = DateTime.Now,
                    PlateNumber = "ABC002",
                    GearBox = ECarGearBox.Automatic,
                    Fuel = ECarFuel.Diesel
                },
            new Car
                {
                Id = 3,
                    Make = "Make3",
                    Model = "Model3",
                    Year = DateTime.Now,
                    PlateNumber = "ABC003",
                    GearBox = ECarGearBox.Manual,
                    Fuel = ECarFuel.Electric
                }
            };
        }
    }
}
