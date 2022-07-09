namespace L014_DNR
{
    internal class Program
    {
        public static bool arNeraTarpuIrVisosDidziosios = false;
        public static bool arPatikrintosRaidesATCG = false;
        public static string txtDNR = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

        static void Main(string[] args)
        {
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
            ParodytiDNR();

            if (!arNeraTarpuIrVisosDidziosios)
                Console.WriteLine("1) Atlikti DNR grandinės normalizavimo veiksmus");
            else
                Console.WriteLine("1) Atlikti DNR grandinės normalizavimo veiksmus - ATLIKTA!");

            if (!arPatikrintosRaidesATCG)
                Console.WriteLine("2) Atlikti grandinės validaciją");
            else
                Console.WriteLine("2) Atlikti grandinės validaciją - ATLIKTA!");

            Console.WriteLine("3) Atlikti veiksmus su DNR grandine");


            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 3))
            {
                switch (pasirinkimas)
                {
                    case "1":
                        GrandinesNormalizavimas();
                        break;
                    case "2":
                        GrandinesValidacija();
                        break;
                    case "3":
                        // do something
                        break;
                    default:
                        // do something else
                        break;
                }
            }
        }


        private static bool ArPasirinkimasYraSkaicius(string text, int max) => int.TryParse(text, out int number) && number > 0 && number <= max;


        private static void ParodytiDNR()
        {
            Console.WriteLine();
            Console.WriteLine($"╔{new String('═', txtDNR.Length)}╗");
            Console.WriteLine("║" + txtDNR + "║");
            Console.WriteLine($"╚{new String('═', txtDNR.Length)}╝");
            Console.WriteLine();
        }

        private static void GrandinesNormalizavimas()
        {
            if (!arNeraTarpuIrVisosDidziosios)
            {
                txtDNR = txtDNR.Trim().Replace(" ", "").ToUpper();
                arNeraTarpuIrVisosDidziosios = true;
                Console.Clear();
                Console.WriteLine("Tarpai panaikinti ir padarytos visos diziosios DNR raides");
                PirmasMeniu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Normalizacija jau buvo atlikta, pasirinkite kita veiksma");
                PirmasMeniu();
            }
        }

        private static void GrandinesValidacija()
        {
            if (!arPatikrintosRaidesATCG)
            {
                if (txtDNR.Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "")
                {
                    arPatikrintosRaidesATCG = true;
                    Console.Clear();
                    Console.WriteLine("Validacija atlikta");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Validacija nepraejo!");
                }
                PirmasMeniu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Validacija jau buvo atlikta, pasirinkite kita veiksma");
                PirmasMeniu();
            }
        }


    }
}