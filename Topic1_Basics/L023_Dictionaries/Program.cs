using System.Linq;
using TRTL;

namespace L023_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu (atskirtus tarpu): ");
            Task1(Console.ReadLine());
        }

        internal static void EXAMPLES()
        {
            // Dictionary deklaravimas
            Dictionary<string, float> KainuZodynas = new Dictionary<string, float>();

            var kainuKintamasisZodynas = new Dictionary<string, float>();

            Dictionary<string, int> miestai = new Dictionary<string, int>
            {
                { "Vilnius", 11 },
                { "Kaunas", 4 },
                { "Siauliai", 6 },
                { "Jonava", 6 },
            };

            Dictionary<string, string> zodziuReiksmes = new Dictionary<string, string>
            {
                {"Macnus","Stipraus, astraus skonio" },
                {"Unaravas", "Pasiputes arba arogantiskas" },
                {"Bimbineti", "Leisti laika be jokio tikslo" }
            };

            var vardai = new Dictionary<int, string>
            {
                {1,"Andrius" },
                {2, "Ieva" },
                {3, "Aiste" },
                {4, "Ieva" },
                {5, "Tomas" },
                {6, "Daiva" }
            };

            var skaiciuZodynas = new Dictionary<int, int>
            {
                {1, 1 },
                {2, 2 },
                {3, 3 },
                {4, 4 },
                {5, 5 }
            };


            Dictionary<string, List<int>> zaidejuTaskuZodynas = new Dictionary<string, List<int>>()
            {
                { "Ieva", new List<int>() { 9, 8, 10 } },
                { "Audrius", new List<int>() { 8, 10, 8, 10, 10 } },
                { "Veronika", new List<int>() { 10, 10, 10 } },
            };

            foreach (var zaidejas in zaidejuTaskuZodynas)
            {
                Console.Write(zaidejas.Key + " ");
                foreach (var taskai in zaidejas.Value)
                {
                    Console.Write(taskai + " ");
                }
                Console.WriteLine();
            }



            // Dictionary skaitymas
            Console.WriteLine(miestai["Vilnius"]);
            Console.WriteLine(miestai["Kaunas"]);

            foreach (KeyValuePair<string, int> miestas in miestai)
            {
                Console.Write(miestas);
                Console.Write(miestas.Key);
                Console.Write(miestas.Value);
                Console.WriteLine();
            }


            // Dictionary pildymas. KeyValuePair
            miestai.Add("Klaipeda", 4);
            miestai["Silute"] = 0;


            // Dictionary iraso validavimas
            if (miestai.TryGetValue("Klaipeda", out int miestoSkaicius))
                Console.WriteLine(miestoSkaicius);
            else
                Console.WriteLine("Irasas nerastas");

            if (!miestai.ContainsKey("Texasas"))
                Console.WriteLine("Miestas nerastas!");


            // Dictionary ValueCollection
            Dictionary<string, int>.ValueCollection miestuSkaiciai = miestai.Values;
            foreach (var skaiciai in miestuSkaiciai)
            {
                Console.WriteLine(skaiciai);
            }

            // Dictionary KeyCollection
            Dictionary<string, int>.KeyCollection miestuRaktai = miestai.Keys;
            foreach (var raktas in miestuRaktai)
            {
                Console.WriteLine(raktas);
            }


            // Dictionary irasu isemimas
            vardai.Remove(4);

            skaiciuZodynas.Clear();

            if (skaiciuZodynas.Count == 0)
                Console.WriteLine("skaiciuZodynas yra tuscias");











        }

        public static void Task1(string text)
        {
            string[] numbers = text.Split(" ");
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                int? num = TRTL.Reusable.IntTryParseOutNull(number);
                if (num != null)
                dict.Add(num.Value, num.Value*num.Value);
            }

            foreach (var d in dict)
            {
                Console.WriteLine($"{d.Key} {d.Value}");
            }
        }

    }
}