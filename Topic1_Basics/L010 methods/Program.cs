namespace L010_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            Console.WriteLine("sukuriame pirma savo methoda");
            Console.WriteLine();


            // metodo kvietimas. nieko negrazina. nieko nepriima.
            SayHi();
            Console.WriteLine("=============================");
            Console.WriteLine();


            // metodo kvietimas. grazinamos reiksmes priskirimas.
            float kazkoksSkaicius = GautiAtsitiktiniSkaiciu();
            Console.WriteLine(kazkoksSkaicius);
            Console.WriteLine("=============================");
            Console.WriteLine();
            

            // metodo kvietimas. metodas su vienu parametru.
            int a = 2;
            IsveskSkaiciuIEkana(a);
            Console.WriteLine($"skaicius a iš MAIN {a}");
            Console.WriteLine("=============================");
            Console.WriteLine();


            // metodo kvietimas. metodas su dviem parametrais grazinantis int.
            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = Sandauga(sk1, sk2);
            Console.WriteLine($"sudauginti {sk1} ir {sk2} yra lygu {sudaugintiDuSkaiciai}");
            Console.WriteLine("=============================");
            Console.WriteLine();


            // metodo kvietimas. METHOD OVERLOAD. metodas su trim parametrais grazinantis int.
            int sudaugintiTrysSkaicius = Sandauga(sk1, sk2, 2);
            Console.WriteLine($"sudauginti {sk1} ir {sk2} ir 2 yra lygu {sudaugintiTrysSkaicius}");
            Console.WriteLine("=============================");
            Console.WriteLine();


            // metodo kvietimas. METHOD OVERLOAD.
            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintiDuDoubleSkaiciai = Sandauga(sk1d, sk2d);
            Console.WriteLine($"sudauginti {sk1d} ir {sk2d} yra lygu {sudaugintiDuDoubleSkaiciai}");
            Console.WriteLine("=============================");
            Console.WriteLine();


            // metodo kvietimas.
            double sudaugintiIntIrDoubleSkaiciai = Sandauga((double)sk1, sk2d);
            Console.WriteLine($"sudauginti {sk1} ir {sk2d} yra lygu {sudaugintiIntIrDoubleSkaiciai}");
            Console.WriteLine("=============================");
            Console.WriteLine();


            // metodo kvietimas. NEPRIVALOMAS PARAMETRAS. Yra default value.
            IsveskTextaIEkrana();
            IsveskTextaIEkrana("bla bla bla");












            Console.WriteLine("-----------------------");
            int patikrintasSkaicius = SkaiciausPatikrinimas(20, 50, 100);
            Console.WriteLine($"patikrintasSkaicius = {patikrintasSkaicius}");

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51);
            Console.WriteLine($"patikrintasSkaicius1 = {patikrintasSkaicius1}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("vidurkis " + Vidurkis(2, 3));
            Console.WriteLine("vidurkis1 " + Vidurkis(2, 3, 8));
            Console.WriteLine("vidurkis2 " + Vidurkis(2, 3, 545, 87, 3, 78, 32, 78, 21, 65, 45, 121));


            Console.WriteLine("-----------------------");

            Console.WriteLine("-----------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautasSkaicius = {gautasSkaicius}");
            Console.WriteLine("-----------------------");


            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reikšmės perdavimas per reference keičia reikšme kviečiančiame metode
            Console.WriteLine($"po ReferenceSkaicius rsk = {rsk}");
            Console.WriteLine("-----------------------");


            Console.WriteLine(Add(Convert.ToInt32(Console.ReadLine()), 2));
            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;
            }



        }
        public static void ReferenceSkaicius(ref int skaicius)
        {
            skaicius = 900;
        }


        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;
        }

        public static double Vidurkis(params int[] skaiciai)
        {
            double total = 0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total / skaiciai.Length;
        }




        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max)
            {
                return max;
            }
            return skaicius;


        }

        public static void IsveskTextaIEkrana(string tekstas = "NEIVESTAS")
        {
            Console.WriteLine("tekstas = " + tekstas);
        }









        private static double Sandauga(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int Sandauga(int sk1, int sk2, int v)
        {
            return sk1 * sk2 * v;
        }

        public static int Sandauga(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static void IsveskSkaiciuIEkana(int a)
        {
            a = a + 300;
            Console.WriteLine($"skaicius a iš methodo {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            float abc = -88;
            return abc + 123.456f;
        }

        public static void SayHi()
        {
            Console.WriteLine("hi");
        }



    }
}