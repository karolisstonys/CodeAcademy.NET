using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030_OOP_Composition
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime FirstRegistration { get; set; }
        public long Odometer { get; set; }
        public string FuelType { get; set; }
        public int Power { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public List<string> Extras { get; set; }
    }
}
