namespace L022_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private static void EXAMPLES()
        {
            int[] taskuMasyvas = new int[10];
            taskuMasyvas[0] = 1;
            foreach (var taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai} - naujas elementas!");
            }

            Console.WriteLine();

            string[] masinos = new string[] { "BMW", "Audi", "Toyota" };
            foreach (var masina in masinos)
            {
                Console.WriteLine(masina);
            }

            Console.WriteLine();

            List<int> amziai = new List<int> { 19, 20, 21 };
            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius: {amzius}");
            }

            List<string> vardai = new List<string> { "Jonas", "Petras", "Antanas" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"Vardas: {vardas}");
            }

            string sakinys = "Labas rytas stai ir as";
            foreach (var raide in sakinys)
            {
                Console.WriteLine(raide);
            }
        }





























    }
}