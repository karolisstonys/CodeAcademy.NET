namespace L02_Task_1.Models
{

    public class Food
    {
        private static int counter = 0;
        public Food(int id, string name, string country, double weight)
        {
            //Id = counter;
            //counter++;
            Id = id;
            Name = name;
            Country = country;
            Weight = weight;
            Created = new DateTime();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
        public DateTime Created { get; set; }
    }
}
