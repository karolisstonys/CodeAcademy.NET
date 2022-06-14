namespace L004_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ====================================================================================================================
            // PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
            // - SKAIČIŲ SUMĄ
            // - SKAIČIŲ SKIRTUMĄ
            // - SANDAUGĄ
            // - DALYBĄ

            /*
            decimal num1;
            decimal num2;

            Console.Write("iveskite skaiciu (1): ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("iveskite skaiciu (2): ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"skaicius1 + skaicius2 = {num1 + num2}");
            Console.WriteLine($"skaicius1 - skaicius2 = {num1 - num2}");
            Console.WriteLine($"skaicius1 * skaicius2 = {num1 * num2}");
            Console.WriteLine($"skaicius1 / skaicius2 = {num1 / num2}");
            */



            // ====================================================================================================================
            // PARAŠYTI PROGRAMĄ, 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ
            
            /*
            decimal numb1;
            decimal numb2;
            decimal numb3;

            Console.Write("iveskite skaiciu (1): ");
            numb1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("iveskite skaiciu (2): ");
            numb2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("iveskite skaiciu (3): ");
            numb3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Skaiciu vidurkis: {(numb1 + numb2 + numb3)/3}");
            */


            // ====================================================================================================================
            /*
            sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
            sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
            - padalinkite didesnį skaičių iš mažesnio
            - iš rezultato atimkite maksimalų long skaičių
            - ir pridėkite maksimalų int skaičių
            */


            // kai dalyba reikia pasicastinti nepamirsti !!! 


            long naujasLongKintamasis = long.MaxValue;      // nenaudoju
            short naujasShortKintamasis = short.MaxValue;   // nenaudoju
            int maxIntKintamasis = int.MaxValue;            // nenaudoju

            var rezultatas1 = long.MaxValue / (long)short.MaxValue;
            var rezultatas2 = (long.MaxValue / short.MaxValue) - long.MaxValue;
            var rezultatas3 = (long.MaxValue / short.MaxValue) - long.MaxValue + int.MaxValue;

            Console.WriteLine($"1. long.MaxValue / short.MaxValue = {rezultatas1}");
            Console.WriteLine();
            Console.WriteLine($"2. (long.MaxValue / short.MaxValue) - long.MaxValue = {rezultatas2}");
            Console.WriteLine();
            Console.WriteLine($"3. ((long.MaxValue / short.MaxValue) - long.MaxValue) + int.MaxValue = {rezultatas3}");
            Console.WriteLine();












        }
    }
}