namespace L07_Api_Car.Models.Dto
{
    public class FilterCarRequest
    {
        /// <summary>
        /// Automobiliu gamintojo pavadinimas
        /// </summary>
        public string Make { get; set; }
        public string Model { get; set; }
        /// <summary>
        /// Automobilio pavaru dezes tipas. Galimos reiksmes: Manual ir Automatic.
        /// </summary>
        public string GearBox { get; set; }
        /// <summary>
        /// Automobilio kuro tipas. Galimos reiksmes: Petrol, Diesel ir Electric.
        /// </summary>
        public string Fuel { get; set; }
    }
}
