﻿namespace L021_List
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Task1A(new List<int> { 5, 1, 6, 8, 7 });
            Task2B(new List<int> { 5, 1, 6, 8, 7 });







        }


        private static void EXAMPLES()
        {
            List<string> stringSarasas = new List<string> { "zodis1", "zodis2", "........" };

            List<int> intSarasas = new List<int> { 1, 22, 33, 44, 5 };

            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };
            Console.WriteLine(string.Join(", ", automobiliai));


            Console.WriteLine(string.Join(", ", automobiliai));

            automobiliai[1] = "Subaru";
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("  "+ automobiliai[2][1]);
            Console.WriteLine("  "+ automobiliai[2]);
            Console.WriteLine("  " + automobiliai[2].Length);

            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("Listo talpa " + automobiliai.Capacity);

            automobiliai.Add("BMW");
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("Listo talpa " + automobiliai.Capacity);

            //Metodai
            //prideti elementa i gala
            automobiliai.Add("Citroen");
            Console.WriteLine(string.Join(", ", automobiliai));

            //prideti daug elementu i gala
            List<string> daugiauAutomobiliu = new List<string> { "BMW", "Mercedes", "Toyota" };
            automobiliai.AddRange(daugiauAutomobiliu);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5  " + automobiliai[5]);

            //isvalyti lista
            automobiliai.Clear();
            Console.WriteLine("isvalyta " + string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);

            //istrinti elementa
            automobiliai.RemoveAt(4);
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5  " + automobiliai[5]);

            //iterpimas
            Console.WriteLine("-------------------------");
            automobiliai.Insert(2, "BMW");
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("automobiliu kiekis " + automobiliai.Count);
            Console.WriteLine("automobilis nr 5  " + automobiliai[5]);

            //paieska
            Console.WriteLine("-------------------------");
            bool arYraVw = automobiliai.Contains("VW");
            Console.WriteLine("Ar yra VW? " + arYraVw);
            bool arYraBmw = automobiliai.Contains("BMW");
            Console.WriteLine("Ar yra BMW? " + arYraBmw);

            //rikiavimas
            Console.WriteLine("-------------------------");
            automobiliai.Sort();
            Console.WriteLine(string.Join(", ", automobiliai));

            automobiliai.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(", ", automobiliai));


            Console.WriteLine("-------------------------");
            intSarasas.Sort();
            Console.WriteLine(string.Join(", ", intSarasas));
            intSarasas.Sort((x, y) => y - x);
            Console.WriteLine(string.Join(", ", intSarasas));

            /// /// /// /// ///

            string[] automobiliuMasyvas = automobiliai.ToArray();

            int[] intMasyvas = new int[] { 1, 2, 3, 4, 5 };
            List<int> skaiciai = intMasyvas.ToList();
        }

        /* 1. DIDŽIAUSIAS SĄRAŠE
        Duotas vienmatis sveikų skaičių sąrašas.
        Parašykite programą, kuri suranda didžiausią skaičių saraše
        { 5, 1, 6, 8, 7 }
        rezultatas:  8
        */
        public static int Task1A(List<int> list)
        {
            int largest = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (largest < list[i])
                    largest = list[i];
            }

            return largest;
        }

        public static int Task1B(List<int> list)
        {
            list.Sort();
            int max = list[list.Count - 1];
            return max;
        }

        /* 2. DIDESNIS UŽ DIDŽIAUSIĄ
        Duotas vienmatis sveikų skaičių sąrašas. 
        Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

        pvz:
        { 5, 1, 6, 8, 7 }
        rezultatas:  5, 1, 6, 8, 7, 9
        */
        public static int[] Task2A(List<int> li)
        {
            int[] arr = new int[li.Count + 1];
            li.CopyTo(arr);
            li.Sort();
            arr[arr.Length - 1] = li[li.Count - 1] + 1;
            return arr;
        }

        public static List<int> Task2B(List<int> li)
        {
            int largest = li[0];
            for (int i = 1; i < li.Count; i++)
            {
                if (largest < li[i])
                    largest = li[i];
            }
            li.Add(largest + 1);
            return li;
        }

        /* 
         
         */









    }
}