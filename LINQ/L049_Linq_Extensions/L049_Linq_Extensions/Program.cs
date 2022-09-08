using System.Linq;

namespace L049_Linq_Extensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ!");

            // LINQ - Language Integrated Query
            // "Data iteration engine", bet jei mes bandytume sutrumpinti kazkas versle nenorejo sio dalyko vadinti DIE

            // IEnumerable sudaro 1 atributas
            // IEnumerator sudaro 2 pagrindiniai atributai: Current property ir Next() metodas

            //IEnumerable<int> result = GenerateNumbers(10);            // calling without yield


            // IEnumerable<int> result = GenerateNumbersWithYield(10);  // calling with yield

            // Pipeline instructions - Grandine veiksmu seku
            IEnumerable<int> result = GenerateNumbersWithYield(10)
                .Where(n => n % 2 == 0)
                .Select(n => n * 3);        // Projection of element
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            LinqSamples();

        }

        public static IEnumerable<int> GenerateNumbers(int maxValue)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < maxValue; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        // yield naudojame tada kada mes zinome, kad nezinome koki kieki duomenu mums reikes laikyti atmintyje
        // Nauda: Performance, speed, doesn;t break the sserver or application
        public static IEnumerable<int> GenerateNumbersWithYield(int maxValue)
        {
            for (int i = 0; i < maxValue; i++)
            {
                // uzdelstas reiksmes grazinimas
                yield return i;
            }
        }



        /* Uzduotis 1: 
        Sarase “List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }” 
        isfiltruokite skaicius, kurie butu didesni arba lygus 35, bet mazesni arba lygus 99. 
        Istestuokite. */

        public static List<int> Task1(List<int> list)
        {
            IEnumerable<int> tempList = list.Where(n => n >= 35).Where(n => n <= 99);
            List<int> result = new List<int>();
            foreach (var i in tempList)
            {
                result.Add(i);
            }

            return result;
        }


        /* Uzduotis 2:
        Parasykite programa, kuri is spalvu saraso 
        “List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", “Magenta”, “Tomato”, “Cyan” }” 
        istrauktu spalvas, kuriu ilgis yra didesnis 4 raides, projekcijos pagalba padarykite, kad visus rezultatus grazintu didziosiomis raidemis. 
        Istestuokite. */

        public static List<string> Task2(List<string> list)
        {
            var result = list.Where(s => s.Length > 4).Select(s => s.ToUpper()).ToList();

            return result;
        }


        public static void LinqSamples()
        {
            List<string> cities = new List<string> { "Vilnius", "Kaunas", "Klaipeda", "Vilnius" };
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            Console.WriteLine("Visi mistai {0}", string.Join(", ", cities));

            Console.WriteLine("Miestai kurie prasideda raide K: {0}", string.Join(", ", cities.Where(c => c.StartsWith("K"))));

            Console.WriteLine("Miestai is K: {0}", cities.Count(c => c.StartsWith("K")));

        }



        /* Uzduotis 3:
        Parasykite programa, kuri is zodziu kratinio 
        “List<string> {“dangus”, “afro”, “vanduo”, “darzelis”, “darzove”, “kremas”, “valdiklis”,”daumantas”, “mokinys”, “pazymys”,”danguole”} 
        isvestu I ekrana zodzius, kurie prasideda raide “d” ir baigiasi raide “s”. 
        Istestuokite. */

        public static List<string> Task3(List<string> list)
        {
            var result = list.Where(l => l.StartsWith("d") && l.EndsWith("s")).ToList();
            return result;
        }







    }
}