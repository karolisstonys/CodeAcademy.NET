using System.Diagnostics;
using System.Globalization;

namespace L015_Skaiciuotuvas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
            //Pinigas();
            //Console.WriteLine(DecimalHour(Console.ReadLine()));

            //DaugiakampioPlotas_Main(null);
        }

        /* MATEMATIKA ---------------------------------------------------
         1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
         - Main metode paprašykite įvesti 2 skaičius
         - Kiekvienas matematinis veiksmas turi turėti savo metodą 
           metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
         - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
         - Visų gautų rezultatų sumą atspausdinti Main metode.
         
        2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
         - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
         - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius (int tipo) ir veiksmą. 
         - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
         - parašyti testus
         - gautą rezultatą atspausdinti į ekraną Main metode.
           
         */

        public static int Suma(int a, int b) => a + b;
        public static int Atimtis(int a, int b) => a - b;
        public static int Daugyba(int a, int b) => a * b;
        public static double Dalyba(int a, int b) => (double)a / b;

        public static double? Skaiciuotuvas(int a, int b, string veiksmas)
        {
            switch (veiksmas) //state machine
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Atimtis(a, b);
                case "*":
                    return Daugyba(a, b);
                case "/":
                    return Dalyba(a, b);
                default:
                    return null;
            }
        }

        /* MATEMATIKA SU PASIRINKIMU---------------------------------------------------
      1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
        (prieštai sukurtų metodų ištrinti negalima)
      2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
        (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
      3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).
      4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas 
        (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija) 
        (Pasirinkimams panaudoti switch sakinį)
          1) +
          2) -
          3) *
          4) /
          5) ^2
          6) ^3
        N.B. Ankstesnis Skaiciuotuvas metodas nemoka atlikti ^2, ir ^3, 
             todel nepriklausomai nuo ar ivesta sveikas ar trupmeninis skaicius reikia nukreipti i naują Matematika metodą
    */

        public static void MatematikaPapildymas_Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu a");
            var a = Console.ReadLine();
            Console.WriteLine("iveskite skaiciu b");
            var b = Console.ReadLine();
            Console.WriteLine(@"Pasirinkite veiksma
            1) +
            2) -
            3) *
            4) /
            5) ^2
            6) ^3
            ");
            var veiksmas = Console.ReadLine();

            double? rezultatas = null;
            rezultatas = Skaiciuotuvas(a, b, veiksmas);

            Console.WriteLine($" {a} {veiksmas} {b} = {rezultatas}");

        }

        public static double? Skaiciuotuvas(string? a, string? b, string? veiksmas)
        {
            VeksmoNormalizacija(ref veiksmas);
            if (ArSvekiejiSkaiciai(a, b) && !ArNaujasVeiksmas(veiksmas))
            {
                return Skaiciuotuvas(Convert.ToInt32(a), Convert.ToInt32(b), veiksmas);
            }
            else if (ArSkaiciai(a, b))
            {
                return Skaiciuotuvas(Convert.ToDouble(a), Convert.ToDouble(b), veiksmas);
            }

            return null;
        }

        public static void VeksmoNormalizacija(ref string veiksmas)
        {
            veiksmas = veiksmas.Replace("1", "+");
            veiksmas = veiksmas.Replace("2", "-");
            veiksmas = veiksmas.Replace("3", "*");
            veiksmas = veiksmas.Replace("4", "/");
            veiksmas = veiksmas.Replace("5", "^2");
            veiksmas = veiksmas.Replace("6", "^3");
        }

        public static bool ArSvekiejiSkaiciai(string a, string b) => int.TryParse(a, out _) && int.TryParse(b, out _);
        public static bool ArSkaiciai(string a, string b) => double.TryParse(a, out _) && double.TryParse(b, out _);
        public static bool ArNaujasVeiksmas(string veiksmas) => veiksmas == "^2" || veiksmas == "^3";

        public static double Suma(double a, double b) => a + b;
        public static double Atimtis(double a, double b) => a - b;
        public static double Daugyba(double a, double b) => a * b;
        public static double Dalyba(double a, double b) => a / b;
        public static double Kvadratu(double a) => a * a;
        public static double Kubu(double a) => a * a * a;

        public static double? Skaiciuotuvas(double a, double b, string veiksmas)
        {
            switch (veiksmas) //state machine
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Atimtis(a, b);
                case "*":
                    return Daugyba(a, b);
                case "/":
                    return Dalyba(a, b);
                case "^2":
                    return Kvadratu(a);
                case "^3":
                    return Kubu(a);
                default:
                    return null;
            }
        }











    }
}