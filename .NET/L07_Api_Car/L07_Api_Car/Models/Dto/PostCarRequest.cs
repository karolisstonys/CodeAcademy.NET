using System.ComponentModel.DataAnnotations;

namespace L07_Api_Car.Models.Dto
{
    public class PostCarRequest
    {
        /// <summary>
        /// Automobiliu gamintojo pavadinimas
        /// </summary>
        [MaxLength(30, ErrorMessage = "Make cannot be longer than 30 symbols")]
        public string Make { get; set; }
        [MaxLength(30, ErrorMessage = "Model cannot be longer than 30 symbols")]
        public string Model { get; set; }
        /// <summary>
        /// Automobilio pagaminimo metai formatu yyyy-MM-dd
        /// </summary>
        [Range(typeof(DateTime), "1900-01-01", "2029-12-31", ErrorMessage = "Year is out of range")]
        public string Year { get; set; }
        [MaxLength(15, ErrorMessage = "PlateNumber cannot be longer than 15 symbols")]
        public string PlateNumber { get; set; }
        /// <summary>
        /// Automobilio pavaru dezes tipas. Galimos reiksmes: Manual ir Automatic.
        /// </summary>
        [MaxLength(12, ErrorMessage = "GearBox cannot be longer than 12 symbols")]
        public string GearBox { get; set; }
        /// <summary>
        /// Automobilio kuro tipas. Galimos reiksmes: Petrol, Diesel ir Electric.
        /// </summary>
        [MaxLength(12, ErrorMessage = "Fuel cannot be longer than 12 symbols")]
        public string Fuel { get; set; }
    }
}
