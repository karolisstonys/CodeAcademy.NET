using System.Diagnostics;
using System.Globalization;

namespace L014_debug
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, DEBUGING!");
            //Pinigas();
            //Console.WriteLine(DecimalHour("20.30"));

            /*
            UŽDUOTIS 1

            1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
            - Main metode paprašykite įvesti 2 skaičius
            - Kiekvienas matematinis veiksmas turi turėti savo metodą
            metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
            - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
            - Visų gautų rezultatų sumą atspausdinti Main metode.

            2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
            - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
            - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą.
            - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
            - parašyti testus
            - gautą rezultatą atspausdinti į ekraną Main metode.
             */


            //Console.Write("Iveskite skaiciu: ");
            //int skaicius1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Iveskite skaiciu: ");
            //int skaicius2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Iveskite matematini veiksma (+ - * /): ");
            //string? veiksmas = Console.ReadLine();          
            //Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {Skaiciuotuvas(skaicius1, skaicius2, veiksmas)}");









            // =====================================================================================================================
            /*
            DAUGIAKAMPIO PLOTAS
            Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį (n) ir kraštinės ilgį (b).,
            metodo parinkimui naudoti switch expression
            1. Kai įvestas trikampis,
            - paprašyti įvesti aukšį h
            - A=1/2bh
            2. Kai įvestas keturkampis,
            - A=b*b
            3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
            - paprašyti įvesti statmenį r
            - A=n/2 * b * r
            4. išvesti betkokio poligono vidinių kampų sumą
            - 180 * (n - 2)
            N.B! atkreipkite dėmesį į metodų testuojamumą.
            visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami
             */


            Console.Write("Iveskite taisyklingojo daugiakampio kraštių kiekį: ");
            int krastiniuKiekis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite kraštinės ilgį: ");
            int krastinesIlgis = Convert.ToInt32(Console.ReadLine());

            var isvedamasRezultatas = krastiniuKiekis switch
            {
                0 or 1 or 2 => "Blogas pasirinkimas",
                3 => TrikampioSkaiciavimas(krastinesIlgis),
                4 => KeturkampioSkaiciavimas(krastinesIlgis),
                5 or 6 or 7 or 8 or 9 or 10 => DaugiakampioSkaiciavimas(krastiniuKiekis, krastinesIlgis),
                _ => PoligonoVidiniuKampuSuma(krastiniuKiekis)
            };
        }

        private static double PoligonoVidiniuKampuSuma(int krastiniuKiekis) => 180 * (krastiniuKiekis - 2);

        public static double DaugiakampioSkaiciavimas(int krastiniuKiekis, int krastinesIlgis, int r = 8)
        {
            Console.Write("Iveskite statmenį r: ");
            r = Convert.ToInt32(Console.ReadLine());
            return (double)krastiniuKiekis/2 * krastinesIlgis * r;
        }

        public static double KeturkampioSkaiciavimas(int krastinesIlgis) => krastinesIlgis * krastinesIlgis;

        public static double TrikampioSkaiciavimas(int krastinesIlgis, int h = 10)
        {
            Console.Write("Iveskite aukšį h: ");
            h = Convert.ToInt32(Console.ReadLine());
            return 0.5D * krastinesIlgis * h;
        }

        public static double Skaiciuotuvas(int skaicius1, int skaicius2, string? veiksmas)
        {
            switch (veiksmas)
            {
                case "+":
                    return Suma(skaicius1, skaicius2);
                case "-":
                    return Atimtis(skaicius1, skaicius2);
                case "*":
                    return Daugyba(skaicius1, skaicius2);
                case "/":
                    return Dalyba(skaicius1, skaicius2);
                default:
                    return 0;
            }
        }

        public static int Suma(int skaicius1, int skaicius2) => skaicius1 + skaicius2;
        public static int Atimtis(int skaicius1, int skaicius2) => skaicius1 - skaicius2;
        public static int Daugyba(int skaicius1, int skaicius2) => skaicius1 * skaicius2;
        public static double Dalyba(int skaicius1, int skaicius2) => (double)skaicius1 / skaicius2;









        public static string DecimalHour(string input)
        {
            var a = input.Split(".");
            if (a.Length < 2)
            {
                return "Invalid time";
            }

            if (!int.TryParse(a[0], out int hour) || hour < 0)
            {
                return "Invalid hours";
            }

            if (!int.TryParse(a[1], out int minute) || minute < 0 || minute > 60)
            {
                return "Invalid minutes";
            }

            if (a.Length > 2 && (!int.TryParse(a[2], out int second) || second < 0 || second > 60))
            {
                return "Invalid seconds";
            }

            var dec = Convert.ToDecimal(a[0]) +
                      (Convert.ToDecimal(a[1])/60) +
                      (a.Length > 2 ? (Convert.ToDecimal(a[2])/ 3600) : 0);


            return $"Decimal hours: {dec}";
        }

        public static void Pinigas()
        {
            Console.Write("Iveskite eurus: ");
            var suma = Console.ReadLine();
            var kursas = 5.6;

            var decimalSepearator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var groupSepearator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;

            var sumaPakeista = suma.Replace(decimalSepearator, groupSepearator);

            var rezultatas = Convert.ToInt32(sumaPakeista) * kursas;
            Console.WriteLine("Jus turite {0} pinigus", rezultatas);

            Debug.WriteLine("Labas rytas");
            Debug.WriteLine("Jus turite {0} pinigus", rezultatas);
            Console.ReadKey();


        }

    }
}