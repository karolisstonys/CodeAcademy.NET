namespace L015_WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Ciklai!");
            /*
             *      1.Paprašyti vartotojo įvesti bet kokį skaičių. 
             *      Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.
             */
            //Uzduotis1();



            /*
             *      Paprašyti vartotojo įvesti bet kokį skaičių. 
             *      Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, 
             *      vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....
             */
            Uzduotis2();

        }

        private static void Uzduotis2()
        {
            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            string ats = "0";

            while (i <= skaicius)
            {
                if (i % 2 == 0)
                    ats += ", " + i;
                if (i == skaicius)
                    ats += ".";
                i++;
            }
            Console.Write("Lyginiai: " + ats);
        }

        private static void Uzduotis1()
        {
            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int suma = 0;

            while (i <= skaicius)
            {
                suma+=i;
                i++;
            }
            Console.Write("Suma: {0}", suma);
        }




    }
}













