namespace L004_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
            // - SKAIČIŲ SUMĄ
            // - SKAIČIŲ SKIRTUMĄ
            // - SANDAUGĄ
            // - DALYBĄ

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

        }
    }
}