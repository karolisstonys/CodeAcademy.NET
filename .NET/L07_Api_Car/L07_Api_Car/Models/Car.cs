using L07_Api_Car.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace L07_Api_Car.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string? PlateNumber { get; set; }
        public ECarGearBox GearBox { get; set; }
        public ECarFuel Fuel { get; set; }
    }
}
