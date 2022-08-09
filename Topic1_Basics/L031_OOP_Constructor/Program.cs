namespace L031_OOP_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        public static void EXAMPLES()
        {
            var klientas1 = new Customer();
            Console.WriteLine(klientas1.Vardas);
            
            klientas1.Vardas = "Benas";
            Console.WriteLine(klientas1.Vardas);

            klientas1 = new Customer()
            {
                Vardas = "Aiste"
            };
            Console.WriteLine(klientas1.Vardas);
        }

        /*
        Uzduotis 3: Aprasykite kiekvienai is klasiu aprasytu 1 uzduotyje po 3 konstruktorius        
        Namą
        Šalį
        Knygą
        */

        public static void Task1()
        {
            var house1 = new House();
            var house2 = new House("Lietuva", "Vilnius", "LT-74000", "Vilniaus g.", "174A", new DateTime(2001-01-01), 1, true);
            var house3 = new House(house1);



            var country1 = new Country();
            var friendlyCountry = new FriendlyCountry();
            var country2 = new Country("Lietuva", 2_795_680, 65_300, friendlyCountry);
            var country3 = new Country(country1);



            var book1 = new Book();
            var release = new Release()
            {
                Date = new DateOnly(1982, 1, 1),
                Publisher = "Sundown Publish",
                CoverType = "Hardcover"
            };
            var book2 = new Book("Do Androids Dream of Electric Sheep?", "Philip K. Dick", "Science fiction", 210, release);
            var book3 = new Book(book1)
            {
                Name = "Snow Crash"
            };




        }





    }
}