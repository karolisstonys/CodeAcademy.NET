namespace L014_DNR
{
    public class Program
    {
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

        string dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
        PirmasMeniu(ref dnr);
        }

        private static void PirmasMeniu(ref string dnr)
        {
            ParodytiDNR(dnr);

            //if (ArNeraTarpuIrVisosDidziosios(dnr))
                Console.WriteLine("1) Atlikti DNR grandinės normalizavimo veiksmus");
            //else
            //    Console.WriteLine("1) DNR grandinė yra normalizuota");

            //if (!arVisosRaidesTikATCG)
                Console.WriteLine("2) Atlikti grandinės validaciją");
            //else
            //    Console.WriteLine("2) DNR grandinė yra validi");

            Console.WriteLine("3)   Atlikti veiksmus su DNR grandine");
            Console.WriteLine("- - - - - - -");
            Console.WriteLine("0)   Reset");


            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 3))
            {
                switch (pasirinkimas)
                {
                    case "0":
                        dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
                        Console.Clear();
                        PirmasMeniu(ref dnr);
                        break;
                    case "1":
                        dnr = GrandinesNormalizavimas(dnr);
                        PirmasMeniu(ref dnr);
                        break;
                    case "2":
                        dnr = GrandinesValidacija(dnr);
                        PirmasMeniu(ref dnr);
                        break;
                    case "3":
                        if (ArGrandineNormalizuotaIrValidi(dnr))
                        {
                            Console.Clear();
                            AntraMeniu(dnr);
                        }
                        else if (ArGrandineTikValidi(dnr))
                        {
                            Console.Clear();
                            AntraMeniuGrandineTikValidi(dnr);
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Pries atliekant tolimesnius veiksmus reikalinka DNR grandines normalizacija ir validacija.");
                            PirmasMeniu(ref dnr);
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
                PirmasMeniu(ref dnr);
            }
        }

        public static bool ArGrandineTikValidi(string dnr) => dnr.Replace(" ", "").ToUpper().Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        public static bool ArGrandineNormalizuotaIrValidi(string dnr) => dnr.Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        // Neimanoma patikrinti ar DNR grandine yra TIK normalizuota ? Be daug daug kodo...
        //private static bool ArGrandineTikNormalizuota(string dnr) => dnr.Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        private static void ParodytiDNR(string dnr)
        {
            Console.WriteLine();
            Console.WriteLine($"╔{new String('═', dnr.Length)}╗");
            Console.WriteLine("║" + dnr + "║");
            Console.WriteLine($"╚{new String('═', dnr.Length)}╝");
            Console.WriteLine();
        }

        public static bool ArPasirinkimasYraSkaicius(string text, int max) => int.TryParse(text, out int number) && number >= 0 && number <= max;

        public static string GrandinesNormalizavimas(string dnr)
        {
            dnr = dnr.Trim().Replace(" ", "").ToUpper();
            Console.Clear();
            Console.WriteLine("Tarpai panaikinti ir padarytos visos diziosios DNR raides");
            return dnr;
        }

        public static string GrandinesValidacija(string dnr)
        {
            if (dnr.Trim().Replace(" ", "").ToUpper().Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "")
            {
                Console.Clear();
                Console.WriteLine("Validacija atlikta.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Validacija nepraejo!");
            }
            return dnr;                 // BLOGAS SPRENDIMAS 
        }
        
        private static void AntraMeniuGrandineTikValidi(string dnr)
        {
            Console.WriteLine("DNR grandinė yra validi, tačiau nenormalizuota!");
            ParodytiDNR(dnr);

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
                        PirmasMeniu(ref dnr);
                        break;
                    case "1":
                        GrandinesNormalizavimas(dnr);
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
                PirmasMeniu(ref dnr);
            }
        }

        private static void AntraMeniu(string dnr)
        {
            ParodytiDNR(dnr);

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
                        PirmasMeniu(ref dnr);
                        break;
                    case "1":
                        GrandinesNormalizavimas(dnr);
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
                        PirmasMeniu(ref dnr);
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
                PirmasMeniu(ref dnr);
            }
        }


    }
}