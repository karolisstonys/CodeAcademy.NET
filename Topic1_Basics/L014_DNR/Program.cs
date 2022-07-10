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
        PirmasMeniu(ref dnr, "");
        }

        private static void PirmasMeniu(ref string dnr, string msg)
        {
            Console.Clear();
            ParodytiDNR(dnr, msg);

            Console.WriteLine("1) Atlikti DNR grandinės normalizavimo veiksmus");            
            Console.WriteLine("2) Atlikti grandinės validaciją");
            Console.WriteLine("3) Atlikti veiksmus su DNR grandine");
            Console.WriteLine();
            Console.WriteLine("0) Reset");

            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 3))
                switch (pasirinkimas)
                {
                    case "0":
                        dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
                        PirmasMeniu(ref dnr, "Reset");
                        break;
                    case "1":
                        dnr = GrandinesNormalizavimas(dnr, out string msg1);
                        PirmasMeniu(ref dnr, msg1);
                        break;
                    case "2":
                        if (GrandinesValidacija(ref dnr))
                            PirmasMeniu(ref dnr, "DNR grandinė yra validi.");
                        else
                            PirmasMeniu(ref dnr, "DNR grandinė nera validi.");
                        break;
                    case "3":
                        if (ArGrandineNormalizuotaIrValidi(dnr))
                            AntrasMeniu(ref dnr, "DNR grandinė yra normalizuota ir validi.");
                        else if (ArGrandineTikValidi(dnr))
                            SubMeniu(ref dnr, "DNR grandinė yra validi, tačiau nenormalizuota!");
                        else 
                            PirmasMeniu(ref dnr, "Pries atliekant tolimesnius veiksmus reikalinka DNR grandines normalizacija ir validacija.");
                        break;
                    default:
                        // do something else
                        break;
                }
            else
                PirmasMeniu(ref dnr, "Blogas pasirinkimas, bandykite dar karta.");
        }

        private static void ParodytiDNR(string dnr, string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine();
            Console.WriteLine($"╔{new String('═', dnr.Length)}╗");
            Console.WriteLine("║" + dnr + "║");
            Console.WriteLine($"╚{new String('═', dnr.Length)}╝");
            Console.WriteLine();
        }

        public static bool ArGrandineTikValidi(string dnr) => dnr.Replace(" ", "").ToUpper().Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        public static bool ArGrandineNormalizuotaIrValidi(string dnr) => dnr.Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        // Neimanoma patikrinti ar DNR grandine yra TIK normalizuota ? Be daug daug kodo...
        //private static bool ArGrandineTikNormalizuota(string dnr) => dnr.Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        private static void SubMeniu(ref string dnr, string msg)
        {
            Console.Clear();
            ParodytiDNR(dnr, msg);

            Console.WriteLine("1) Normalizuoti grandinę");
            Console.WriteLine("2) Išeiti iš programos");
            Console.WriteLine();
            Console.WriteLine("0) Gryžti į ankstesnį meniu");

            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 2))
                switch (pasirinkimas)
                {
                    case "0":
                        PirmasMeniu(ref dnr, "");
                        break;
                    case "1":
                        dnr = GrandinesNormalizavimas(dnr, out string msg1);
                        AntrasMeniu(ref dnr, msg1);
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        // do something else
                        break;
                }
            else
                PirmasMeniu(ref dnr, "Blogas pasirinkimas, bandykite dar karta.");
        }

        private static void AntrasMeniu(ref string dnr, string msg)
        {
            Console.Clear();
            ParodytiDNR(dnr, msg);

            Console.WriteLine("1) GCT pakeis į AGG");
            Console.WriteLine("2) Išvesti ar yra tekste CAT");
            Console.WriteLine("3) Išvesti trečia ir penktą grandinės segmentus");
            Console.WriteLine("4) Išvesti raidžių kiekį tekste");
            Console.WriteLine("5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas");
            Console.WriteLine("6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą");
            Console.WriteLine("7) Iš grandinės pašalinti pasirinką elementą");
            Console.WriteLine("8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros");
            Console.WriteLine();
            Console.WriteLine("0) Gryžti į ankstesnį meniu");

            Console.WriteLine();
            Console.Write("Veiksmas: ");
            string pasirinkimas = Console.ReadLine();

            if (ArPasirinkimasYraSkaicius(pasirinkimas, 8))
                switch (pasirinkimas)
                {
                    case "0":
                        PirmasMeniu(ref dnr, "");
                        break;
                    case "1":
                        dnr = dnr.Replace("GCT", "AGG");
                        AntrasMeniu(ref dnr, "GCT pakeisti į AGG");
                        break;
                    case "2":
                        AntrasMeniu(ref dnr, dnr.Contains("CAT").ToString().Replace("True", "Teskste YRA CAT.").Replace("False", "Teskste NERA CAT"));
                        break;
                    case "3":
                        AntrasMeniu(ref dnr, "Trecias grandines elementas: " + dnr.Substring(8, 3) + ". Penktas grandines elementas: " + dnr.Substring(16, 3) + ".");
                        break;
                    case "4":
                        string composition = "Raidziu kiekis DNR grandineje yra " + dnr.Replace("-", "").Length;
                        AntrasMeniu(ref dnr, composition);
                        break;
                    case "5":
                        Console.Write("Ieskoti teksto: ");
                        string paieska = Console.ReadLine();
                        var kartai = Convert.ToDouble(dnr.Length -  dnr.Replace(paieska, "").Length) / paieska.Length;
                        if (kartai == 0)
                            AntrasMeniu(ref dnr, "Ivestu raidziu DNR grandineje NERA.");
                        else
                            AntrasMeniu(ref dnr, "Ivestos raides DNR grandineje YRA. Kartojasi" + kartai);
                        break;
                    case "6":
                        Console.Write("Pridėkite norima (ATCG) triju raidžių seką prie DNR grandinės galo: ");
                        string pridetiString = Console.ReadLine();
                        bool arPrideta = PridejimasPrieGrandinesGalo(ref dnr, pridetiString);
                        AntrasMeniu(ref dnr, arPrideta.ToString().Replace("True", "Pridėta sekmingai").Replace("False", "Teskstas netinkamas!"));
                        break;
                    case "7":
                        Console.Write("Pasirinkite elementa kuri norite pasalinti (galima rasyt elemento numeri arba visas raides): ");
                        string elementasPasalinimui = Console.ReadLine();
                        bool arPasalinta = SalinamasElementas(ref dnr, elementasPasalinimui);
                        AntrasMeniu(ref dnr, arPasalinta.ToString().Replace("True", "Elementas pasalintas sekmingai.").Replace("False", "Toks elementas nerastas!"));
                        break;
                    case "8":
                        Console.Write("Pasirinkite elementa kuri norite keisti (galima rasyt elemento numeri arba visas raides): ");
                        string elementasKeitimui = Console.ReadLine();
                        Console.Write("Iveskite raidziu seka kuria norite pakeisti (ATCG): ");
                        string keiciamas = Console.ReadLine();

                        bool arPakeista = KeiciamasElementas(ref dnr, elementasKeitimui, keiciamas, out string msg1);
                        AntrasMeniu(ref dnr, msg1);
                        break;
                    default:
                        // do something else
                        break;
                }
            else
                AntrasMeniu(ref dnr, "Blogas pasirinkimas, bandykite dar karta.");
        }

        public static bool ArPasirinkimasYraSkaicius(string text, int max) => int.TryParse(text, out int number) && number >= 0 && number <= max;

        public static string GrandinesNormalizavimas(string dnr, out string msg1)
        {
            dnr = dnr.Trim().Replace(" ", "").ToUpper();
            msg1 = "Tarpai panaikinti ir padarytos visos diziosios DNR raides";
            return dnr;
        }

        public static bool GrandinesValidacija(ref string dnr) => dnr.Trim().Replace(" ", "").ToUpper().Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "") == "";

        public static bool PridejimasPrieGrandinesGalo(ref string dnr, string prideti)
        {
            if (prideti.Length == 3 && prideti.ToUpper().Replace("A","").Replace("T", "").Replace("C", "").Replace("G", "") == "")
            {
                dnr = dnr + "-" + prideti.ToUpper();
                return true;
            }
            else
                return false;
        }

        public static bool SalinamasElementas(ref string dnr, string? elementasPasalinimui)
        {
            int dnrElementuKiekis = (dnr.Length + 1) / 4;
            if ((elementasPasalinimui.Length == 1 || elementasPasalinimui.Length == 2) &&
                int.TryParse(elementasPasalinimui, out int intElementasSalinimui) &&
                intElementasSalinimui > 0 &&
                intElementasSalinimui <= dnrElementuKiekis)
            {
                if (intElementasSalinimui == 1)
                {
                    dnr = dnr.Remove(0, 4);
                    return true;
                }
                else if (intElementasSalinimui == dnrElementuKiekis)
                {
                    dnr = dnr.Remove(dnr.Length - 5, 4);
                    return true;
                }
                else
                {
                    dnr = dnr.Remove(intElementasSalinimui * 4 - 4, 4);
                    return true;
                }
            }
            else if (elementasPasalinimui.Length == 3 &&
                     ArGrandineTikValidi(elementasPasalinimui.ToUpper()) &&
                     dnr.Contains(elementasPasalinimui.ToUpper()))
            {
                if (dnr.IndexOf(elementasPasalinimui.ToUpper()) == 0)
                {
                    dnr = dnr.Remove(0, 4);
                    return true;
                }
                else if (dnr.IndexOf(elementasPasalinimui.ToUpper()) == dnr.Length - 4)
                {
                    dnr = dnr.Remove(dnr.Length - 5, 4);
                    return true;
                }
                else
                {
                    dnr = dnr.Remove(dnr.IndexOf(elementasPasalinimui.ToUpper()), 4);
                    return true;
                }
            }
            else
            return false;
        }

        private static bool KeiciamasElementas(ref string dnr, string? elementasKeitimui, string? keiciamas, out string msg1)
        {
            if (keiciamas.Length == 3 &&
                ArGrandineTikValidi(keiciamas))
            {

                int dnrElementuKiekis = (dnr.Length + 1) / 4;
                if ((elementasKeitimui.Length == 1 || elementasKeitimui.Length == 2) &&
                    int.TryParse(elementasKeitimui, out int intElementasKeitimui) &&
                    intElementasKeitimui > 0 &&
                    intElementasKeitimui <= dnrElementuKiekis)
                {
                    if (intElementasKeitimui == 1)
                    {
                        //dnr = dnr.Remove(0, 4);
                        msg1 = "Pakeista sekmingai";
                        return true;
                    }
                    else if (intElementasKeitimui == dnrElementuKiekis)
                    {
                        //dnr = dnr.Remove(dnr.Length - 5, 4);
                        msg1 = "Pakeista sekmingai";
                        return true;
                    }
                    else
                    {
                        //dnr = dnr.Remove(intElementasKeitimui * 4 - 4, 4);
                        msg1 = "Pakeista sekmingai";
                        return true;
                    }
                }
                else if (elementasKeitimui.Length == 3 &&
                         ArGrandineTikValidi(elementasKeitimui.ToUpper()) &&
                         dnr.Contains(elementasKeitimui.ToUpper()))
                {
                    if (dnr.IndexOf(elementasKeitimui.ToUpper()) == 0)
                    {
                        //dnr = dnr.Remove(0, 4);
                        msg1 = "Pakeista sekmingai";
                        return true;
                    }
                    else if (dnr.IndexOf(elementasKeitimui.ToUpper()) == dnr.Length - 4)
                    {
                        //dnr = dnr.Remove(dnr.Length - 5, 4);
                        msg1 = "Pakeista sekmingai";
                        return true;
                    }
                    else
                    {
                        //dnr = dnr.Remove(dnr.IndexOf(elementasKeitimui.ToUpper()), 4);
                        msg1 = "Pakeista sekmingai";
                        return true;
                    }
                }
                else
                {
                    msg1 = "Toks elementas nerastas!";
                    return false;
                }
            }
            else
            {
                msg1 = "Keiciamas tekstas neta tinkamas!";
                return false;
            }
        }













    }
}