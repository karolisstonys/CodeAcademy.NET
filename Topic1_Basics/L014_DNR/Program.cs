namespace L014_DNR
{
    internal class Program
    {
        public static bool arNeraTarpuIrVisosDidziosios = false;
        public static bool arVisosRaidesTikATCG = false;
        public static string txtDNR = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

        static void Main(string[] args)
        {
            //==============================================================================================================================
            /*
            DNR inžinerija

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

            PirmasMeniu();
        }

        private static void PirmasMeniu()
        {
            ParodytiDNR();

            if (!arNeraTarpuIrVisosDidziosios)
                Console.WriteLine("1)   Atlikti DNR grandinės normalizavimo veiksmus");
            else
                Console.WriteLine("1) + Atlikti DNR grandinės normalizavimo veiksmus");

            if (!arVisosRaidesTikATCG)
                Console.WriteLine("2)   Atlikti grandinės validaciją");
            else
                Console.WriteLine("2) + Atlikti grandinės validaciją");

            Console.WriteLine("3)   Atlikti veiksmus su DNR grandine");
            Console.WriteLine("0)   Reset");


            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 3))
            {
                switch (pasirinkimas)
                {
                    case "0":
                        arNeraTarpuIrVisosDidziosios = false;
                        arVisosRaidesTikATCG = false;
                        txtDNR = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
                        Console.Clear();
                        PirmasMeniu();
                        break;
                    case "1":
                        GrandinesNormalizavimas();
                        break;
                    case "2":
                        GrandinesValidacija();
                        break;
                    case "3":
                        if (arNeraTarpuIrVisosDidziosios && arVisosRaidesTikATCG)
                        {
                            Console.Clear();
                            AntraMeniu();
                        }
                        else if (!arNeraTarpuIrVisosDidziosios && arVisosRaidesTikATCG)
                        {
                            Console.Clear();
                            AntraMeniuBeNormalizavimo();
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Pries atliekant tolimesnius veiksmus reikalinka DNR grandines normalizacija ir validacija.");
                            PirmasMeniu();
                        }
                        break;
                    default:
                        // do something else
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Blogas pasirinkimas, bandykite dar karta.");
                PirmasMeniu();
            }
        }

        private static void ParodytiDNR()
        {
            Console.WriteLine();
            Console.WriteLine($"╔{new String('═', txtDNR.Length)}╗");
            Console.WriteLine("║" + txtDNR + "║");
            Console.WriteLine($"╚{new String('═', txtDNR.Length)}╝");
            Console.WriteLine();
        }

        private static bool ArPasirinkimasYraSkaicius(string text, int max) => int.TryParse(text, out int number) && number >= 0 && number <= max;

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
            if (!arVisosRaidesTikATCG)
            {
                if (txtDNR.Trim().Replace(" ", "").ToUpper().Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "")
                {
                    arVisosRaidesTikATCG = true;
                    Console.Clear();
                    Console.WriteLine("Validacija atlikta.");
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
                Console.WriteLine("Validacija jau buvo atlikta, pasirinkite kita veiksma.");
                PirmasMeniu();
            }
        }
        
        private static void AntraMeniuBeNormalizavimo()
        {
            Console.WriteLine("DNR grandinė yra validi, tačiau nenormalizuota!");
            ParodytiDNR();

            Console.WriteLine("1)   Normalizuoti grandinę");
            Console.WriteLine("2)   Išeiti iš programos");
            Console.WriteLine("0)   Gryžti į ankstesnį meniu");

            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 2))
            {
                switch (pasirinkimas)
                {
                    case "0":
                        Console.Clear();
                        PirmasMeniu();
                        break;
                    case "1":
                        GrandinesNormalizavimas();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;                    
                    default:
                        // do something else
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Blogas pasirinkimas, bandykite dar karta.");
                PirmasMeniu();
            }
        }

        private static void AntraMeniu()
        {
            ParodytiDNR();

            Console.WriteLine("1) GCT pakeis į AGG");
            Console.WriteLine("2) Išvesti ar yra tekste CAT");
            Console.WriteLine("3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).");
            Console.WriteLine("4) Išvesti raidžių kiekį tekste (naudoti string composition)");
            Console.WriteLine("5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas");
            Console.WriteLine("6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą");
            Console.WriteLine("7) Iš grandinės pašalinti pasirinką elementą");
            Console.WriteLine("8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros");
            Console.WriteLine("9) Gryžti į ankstesnį meniu");

            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 2))
            {
                switch (pasirinkimas)
                {
                    case "0":
                        Console.Clear();
                        PirmasMeniu();
                        break;
                    case "1":
                        GrandinesNormalizavimas();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        Console.Clear();
                        PirmasMeniu();
                        break;
                    default:
                        // do something else
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Blogas pasirinkimas, bandykite dar karta.");
                PirmasMeniu();
            }
        }


    }
}