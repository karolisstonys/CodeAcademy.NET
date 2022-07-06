using System.Diagnostics;
using System.Globalization;

namespace L014_debug
{
    public class Program
    {
        public static bool arNeraTarpuIrVisosDidziosios = false;
        public static bool arPatikrintosATCG = false;
        public static string txtDNR = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";


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









            //=====================================================================================================================
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


            //Console.Write("Iveskite taisyklingojo daugiakampio kraštių kiekį (3+): ");
            //int krastiniuKiekis = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Iveskite kraštinės ilgį: ");
            //int krastinesIlgis = Convert.ToInt32(Console.ReadLine());
            //int r = 0;
            //int h = 0;

            //if (krastiniuKiekis >= 3)
            //{
            //    if (krastiniuKiekis == 3)
            //    {
            //        Console.Write("Iveskite kraštinės ilgį (h): ");
            //        h = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (krastiniuKiekis >= 5)
            //    {
            //        Console.Write("Iveskite statmenį (r): ");
            //        r = Convert.ToInt32(Console.ReadLine());
            //    }

            //    var isvedamasRezultatas = krastiniuKiekis switch        // state machine
            //    {
            //        3 => TrikampioSkaiciavimas(krastinesIlgis, h),
            //        4 => KeturkampioSkaiciavimas(krastinesIlgis),
            //        _ => DaugiakampioSkaiciavimas(krastiniuKiekis, krastinesIlgis, r)
            //    };

            //    Console.Write($"Atsakymas: {isvedamasRezultatas}");
            //    Console.Write($"Poligono vidinių kampų suma: {PoligonoVidiniuKampuSuma(krastiniuKiekis)}");

            //}
            //else
            //{
            //    Console.WriteLine("Blogai įvestas kraštių kiekis!");
            //    Environment.Exit(0);
            //}




            //=====================================================================================================================
            /*
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
                5) a^2
                6) a^3
            */

            //int intSkaicius1 = 0;
            //double doubleSkaicius1 = 0;
            //int intSkaicius2 = 0;
            //double doubleSkaicius2 = 0;

            //Console.Write("Iveskite pirma skaiciu: ");
            //string stringSkaicius1 = Console.ReadLine();

            //if (!IsNumber(stringSkaicius1))
            //{
            //    Console.WriteLine("Ivestas ne skaicius!");
            //    Environment.Exit(0);
            //}

            //if (SkaiciusTuriKableli(stringSkaicius1))
            //{
            //    doubleSkaicius1 = Convert.ToDouble(stringSkaicius1);
            //    Debug.WriteLine("Skaicius 1 yra double");
            //}
            //else
            //{
            //    intSkaicius1 = Convert.ToInt32(stringSkaicius1);
            //    Debug.WriteLine("Skaicius 1 yra int");
            //}

            //Console.Write("Iveskite antra skaiciu: ");
            //string stringSkaicius2 = Console.ReadLine();

            //if (!IsNumber(stringSkaicius2))
            //{
            //    Console.WriteLine("Ivestas ne skaicius!");
            //    Environment.Exit(0);
            //}

            //if (SkaiciusTuriKableli(stringSkaicius2))
            //{
            //    doubleSkaicius2 = Convert.ToDouble(stringSkaicius2);
            //    Debug.WriteLine("Skaicius 2 yra double");
            //}
            //else
            //{
            //    intSkaicius2 = Convert.ToInt32(stringSkaicius2);
            //    Debug.WriteLine("Skaicius 2 yra int");
            //}

            //VeiksmuMeniuIrSkaiciavimas(stringSkaicius1, stringSkaicius2, doubleSkaicius1, doubleSkaicius2, intSkaicius1, intSkaicius2);

















            //==============================================================================================================================
            /*
            Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
            Galimos bazės: Adenine, Thymine, Cytosine, Guanine
            Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
            1. Atlikti DNR grandinės normalizavimo veiksmus:
            - pašalina tarpus.
            - visas raides keičia didžiosiomis.
            2. Atlikti grandinės validaciją
            - patikrina ar nėra kitų nei ATCG raidžių
            3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
            - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui
            1) normalizuoti grandinę
            2) išeiti iš programos
            - jei grandinė normalizuota arba kai buvo atlikta normalizacija
            1) GCT pakeis į AGG
            2) Išvesti ar yra tekste CAT
            3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
            4) Išvesti raidžių kiekį tekste (naudoti string composition)
            5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas
            6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą
            (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
            7) Iš grandinės pašalinti pasirinką elementą
            8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros
            (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
            9) Gryžti į ankstesnį meniu
            Visoms operacijoms reikalingi testai. 
            */

            // arNeraTarpuIrVisosDidziosios = false;

            // arPatikrintosATCG = false;

            // string txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

            PirmasMeniu();

        }


        

        private static void PirmasMeniu()
        {
            Console.Clear();
            Console.WriteLine(txtDNR);
            Console.WriteLine("Galimi pasirinkimai");
            if (!arNeraTarpuIrVisosDidziosios)
                Console.WriteLine("1) Atlikti DNR grandinės normalizavimo veiksmus");
            else
                Console.WriteLine("1) Atlikti DNR grandinės normalizavimo veiksmus - ATLIKTA!");
            if (!arPatikrintosATCG)
                Console.WriteLine("2) Atlikti grandinės validaciją");
            else
                Console.WriteLine("2) Atlikti grandinės validaciją - ATLIKTA!");
            Console.WriteLine("3) Atlikti veiksmus su DNR grandine");

            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 3))
            {

            }

            //string rezultatas = pasirinkimas switch
            //{
            //    "1" => "",
            //    "2" => "",
            //    "3" => "",
            //    _ => ""
            //};
        }










        private static bool ArPasirinkimasYraSkaicius(string text, int max) => int.TryParse(text, out int number) && number > 0 && number <= max;

        private static void VeiksmuMeniuIrSkaiciavimas(string stringSkaicius1, string stringSkaicius2, double doubleSkaicius1, double doubleSkaicius2, int intSkaicius1, int intSkaicius2)
        {
            Console.WriteLine("Pasirinkite veiksma:");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) a^2");
            Console.WriteLine("6) a^3");

            switch (Console.ReadLine())
            {
                case "1" or "+":
                    if (SkaiciusTuriKableli(stringSkaicius1) || SkaiciusTuriKableli(stringSkaicius2))
                    {
                        Console.WriteLine("Suma: {0}", Skaiciuotuvas(doubleSkaicius1, doubleSkaicius2, "+"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(double, double, \"+\")");
                    }
                    else
                    {
                        Console.WriteLine("Suma: {0}", Skaiciuotuvas(intSkaicius1, intSkaicius2, "+"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(int, int, \"+\")");
                    }
                    break;

                case "2" or "-":
                    if (SkaiciusTuriKableli(stringSkaicius1) || SkaiciusTuriKableli(stringSkaicius2))
                    {
                        Console.WriteLine("Atimtis: {0}", Skaiciuotuvas(doubleSkaicius1, doubleSkaicius2, "-"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(double, double, \"-\")");
                    }
                    else
                    {
                        Console.WriteLine("Atimtis: {0}", Skaiciuotuvas(intSkaicius1, intSkaicius2, "-"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(int, int, \"-\")");
                    }
                    break;

                case "3" or "*":
                    if (SkaiciusTuriKableli(stringSkaicius1) || SkaiciusTuriKableli(stringSkaicius2))
                    {
                        Console.WriteLine("Daugyba: {0}", Skaiciuotuvas(doubleSkaicius1, doubleSkaicius2, "*"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(double, double, \"*\")");
                    }
                    else
                    {
                        Console.WriteLine("Daugyba: {0}", Skaiciuotuvas(intSkaicius1, intSkaicius2, "*"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(int, int, \"*\")");
                    }
                    break;

                case "4" or "/":
                    if (SkaiciusTuriKableli(stringSkaicius1) || SkaiciusTuriKableli(stringSkaicius2))
                    {
                        Console.WriteLine("Dalyba: {0}", Skaiciuotuvas(doubleSkaicius1, doubleSkaicius2, "/"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(double, double, \"/\")");
                    }
                    else
                    {
                        Console.WriteLine("Dalyba: {0}", Skaiciuotuvas(intSkaicius1, intSkaicius2, "/"));
                        Debug.WriteLine("Naudojam Skaiciuotuvas(int, int, \"/\")");
                    }
                    break;

                case "5":
                    if (SkaiciusTuriKableli(stringSkaicius1))
                    {
                        Console.WriteLine("Kvadratu: {0}", PirmoSkaiciausKelimasKvadratu(doubleSkaicius1));
                        Debug.WriteLine("Naudojam PirmoSkaiciausKelimasKvadratu(double)");
                    }
                    else
                    {
                        Console.WriteLine("Kvadratu: {0}", PirmoSkaiciausKelimasKvadratu(intSkaicius1));
                        Debug.WriteLine("Naudojam PirmoSkaiciausKelimasKvadratu(int)");
                    }
                    break;

                case "6":
                    if (SkaiciusTuriKableli(stringSkaicius1))
                    {
                        Console.WriteLine("Kubu: {0}", PirmoSkaiciausKelimasKubu(doubleSkaicius1));
                        Debug.WriteLine("Naudojam PirmoSkaiciausKelimasKubu(double)");
                    }
                    else
                    {
                        Console.WriteLine("Kubu: {0}", PirmoSkaiciausKelimasKubu(intSkaicius1));
                        Debug.WriteLine("Naudojam PirmoSkaiciausKelimasKubu(int)");
                    }
                    break;

                default:
                    Console.WriteLine("Blogas pasirinkimas!");
                    break;
            }
        }

        private static bool IsNumber(string text) => int.TryParse(text, out _);

        private static bool SkaiciusTuriKableli(string skaicius) => skaicius.Contains(",");

        public static double PoligonoVidiniuKampuSuma(int krastiniuKiekis) => 180 * (krastiniuKiekis - 2);

        public static double DaugiakampioSkaiciavimas(int krastiniuKiekis, int krastinesIlgis, int r) => (double)krastiniuKiekis/2 * krastinesIlgis * r;
        
        public static double KeturkampioSkaiciavimas(int krastinesIlgis) => krastinesIlgis * krastinesIlgis;

        public static double TrikampioSkaiciavimas(int krastinesIlgis, int h) => 0.5D * krastinesIlgis * h;






        public static double Skaiciuotuvas(int skaicius1, int skaicius2, string? veiksmas)
        {
            switch (veiksmas)       // state machine
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
        public static double Skaiciuotuvas(double skaicius1, double skaicius2, string? veiksmas)
        {
            switch (veiksmas)       // state machine
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

        public static int PirmoSkaiciausKelimasKvadratu(int skaicius1) => skaicius1 * skaicius1;

        public static int PirmoSkaiciausKelimasKubu(int skaicius1) => skaicius1 * skaicius1 * skaicius1;







        public static double Suma(double skaicius1, double skaicius2) => skaicius1 + skaicius2;

        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;

        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;

        public static double Dalyba(double skaicius1, double skaicius2) => skaicius1 / skaicius2;

        public static double PirmoSkaiciausKelimasKvadratu(double skaicius1) => skaicius1 * skaicius1;

        public static double PirmoSkaiciausKelimasKubu(double skaicius1) => skaicius1 * skaicius1 * skaicius1;






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