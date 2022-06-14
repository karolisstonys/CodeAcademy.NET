namespace L005_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Reliaciniai operatoriai == != > < >= <=

            var skaicius = 10;
            var nelyginisSkaicius = 5;
            var lyginisSkaicius = 10;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("== patikrina ar kintamieji yra lygus");
            Console.WriteLine($"{skaicius} == {lyginisSkaicius} - {skaicius == lyginisSkaicius}");
            bool is10equal5 = skaicius == nelyginisSkaicius;
            Console.WriteLine($"{skaicius} == {nelyginisSkaicius} - {is10equal5}");


            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("!= patikrina ar kintamieji yra nelygus");
            Console.WriteLine($"{skaicius} != {lyginisSkaicius} - {skaicius != lyginisSkaicius}");
            Console.WriteLine($"{skaicius} != {nelyginisSkaicius} - {skaicius != nelyginisSkaicius}");


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("> patikrina ar kairiojo kintamojo REIKSME yra didesne uz dezinio");
            Console.WriteLine($"{skaicius} > {lyginisSkaicius} - {skaicius > lyginisSkaicius}");
            Console.WriteLine($"{skaicius} > {nelyginisSkaicius} - {skaicius > nelyginisSkaicius}");


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("< patikrina ar kairiojo kintamojo REIKSME yra mazesne uz dezinio");
            Console.WriteLine($"{skaicius} < {lyginisSkaicius} - {skaicius < lyginisSkaicius}");
            Console.WriteLine($"{skaicius} < {nelyginisSkaicius} - {skaicius < nelyginisSkaicius}");


            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine(">= patikrina ar kairiojo kintamojo REIKSME yra didesne arba lygi uz dezinio");
            Console.WriteLine($"{skaicius} >= {lyginisSkaicius} - {skaicius >= lyginisSkaicius}");
            Console.WriteLine($"{skaicius} >= {nelyginisSkaicius} - {skaicius >= nelyginisSkaicius}");


            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("<= patikrina ar kairiojo kintamojo REIKSME yra arba lygi mazesne uz dezinio");
            Console.WriteLine($"{skaicius} <= {lyginisSkaicius} - {skaicius <= lyginisSkaicius}");
            Console.WriteLine($"{skaicius} <= {nelyginisSkaicius} - {skaicius <= nelyginisSkaicius}");









        }
    }
}