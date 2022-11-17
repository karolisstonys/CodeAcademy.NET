namespace L02_Rest_Endpoints.Models.Dto
{
    public class FoodDTO
    {
        //private static int counter = 0;

        public FoodDTO() { }

        public FoodDTO(int id, string name, string country, double weight)
        {
            //Id = counter;
            //counter++;
            Id = id;
            Name = name;
            Country = country;
            Weight = weight;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
    }
}
