namespace L029_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }



        public static void EXAMPLES()
        {
            // deklaruojame nauja objektyva naudodami Human kaip klase
            var human = new Human();
            Console.WriteLine($"human FirstName:{human.FirstName} LastName:{human.LastName}");
            Console.WriteLine();

            human.FirstName = "Andrius";
            human.LastName = "Andriuskevicius";
            Console.WriteLine($"human FirstName:{human.FirstName} LastName:{human.LastName}");
            Console.WriteLine();

            var human2 = human;
            Console.WriteLine($"human2 FirstName:{human2.FirstName} LastName:{human2.LastName}");
        }

        public static void DogOOP()
        {
            var pilkius = new Dog("Pilkius", 5);
            //var owner = new Owner()
            //{
            //    Name = "Jonas";
            //}
        }


    }

    class Dog
    {
        public string name;
        public int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Talk()
        {
            Console.WriteLine($"{name} says 'BARK'!");
        }

    }

    class Owner
{
    public Owner(string name)
    {
        //Dogs = new 
    }
}


    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }



}