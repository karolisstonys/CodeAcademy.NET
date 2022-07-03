namespace L010_tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 1
            // ==============================================================================
            /* 1
            Parašykite programą kurioje yra 2 metodai.
            - Pirmas metodas į konsolę išveda "Sveiki visi"
            - Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
            */

            sveiki();
            iki();

            #endregion

            #region 2
            // ==============================================================================
            /* 2
            Parašykite programą kurioje yra 2 metodai.
            - Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
            - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
            Pvz:
            > Iveskite savo Varda:
            _ Petras
            > Labas Petras
            > Linkiu jums Petras geros dienos
            */

            string name = sveikiSuVardu();
            ikiSuVardu(name);

            #endregion

            #region 3
            // ==============================================================================
            /* 3
            Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
            - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
            N.B. būtina validacija
            - Į ekraną išveskite argumentų matematinę sumą.
            Pvz:
            > Iveskite pirmą skaičių:
            _ 15
            > Iveskite antrą skaičių:
            _ 16
            > Rezultatas: 31
            */

            Console.Write("Iveskite pirmą skaičių: ");
            string skA1 = Console.ReadLine();

            Console.Write("Iveskite antrą skaičių: ");
            string skA2 = Console.ReadLine();

            bool arSkA1 = int.TryParse(skA1, out int intSkA1);
            bool arSkA2 = int.TryParse(skA2, out int intSkA2);

            if (arSkA1 && arSkA2)
            {
                MatematineSuma(intSkA1, intSkA2);
            }
            else
            {
                Console.WriteLine("Ivesta blogai");
            }

            #endregion

            #region 4
            // ==============================================================================
            /* 4
            Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
            - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
            - Main metode į ekraną išveskite tarpų kiekį
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > Tarpu kiekis yra: 2
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais: ");
            string tekstasSuTarpais = Console.ReadLine();

            int kiekTarpu = SkaiciuojamTarpus(tekstasSuTarpais, 1);

            Console.WriteLine($"tekste yra {kiekTarpu} tarpų");

            #endregion

            #region 5
            // ==============================================================================
            /* 5
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti betkokį tekstą Main metode.
            - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
            Pvz:
            > Iveskite teksta:
            _ ' as mokausi '
            > Teksto ilgis yra: 10
            */

            int kiekRaidziuBeTarpu = SkaiciuojamTarpus(tekstasSuTarpais, 2);
            Console.WriteLine($"tekstas be tarpų yra {kiekRaidziuBeTarpu} ilgio");

            #endregion

            #region 6
            // ==============================================================================
            /* 6
            Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
            - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
            - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
            - Main metode į ekraną išveskite žodžių kiekį
            Pvz: 
            > Iveskite teksta:
            _ as mokausi programuoti
            > Zodziu kiekis yra: 3
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais: ");
            string tekstasSuTarpais2 = Console.ReadLine();

            int kiekZodziu = SkaiciuojamZodzius(tekstasSuTarpais2);

            Console.WriteLine($"tekste yra {kiekZodziu} zodziu");

            #endregion

            #region 7
            // ==============================================================================
            /* 7
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti betkokį tekstą Main metode.
            - Metodas grąžina tarpų kiekį teksto gale
            - Main į ekraną išveda rezultatą
            Pvz:
            > Iveskite teksta:
            _ ' as mokausi      '
            > Gale yra tarpų: 6
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais + daug tarpu gale: ");
            string tekstasSuTarpaisGale = Console.ReadLine();

            int kiekGaleTarpu = SkaiciuojamGaloWhitespace(tekstasSuTarpaisGale);
            Console.WriteLine($"Gale yra {kiekGaleTarpu} tarpu");

            #endregion

            #region 8
            // ==============================================================================
            /* 8
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti betkokį tekstą Main metode.
            -Metodas grąžina tarpų kiekį teksto pradžioje
            - Main į ekraną išveda rezultatą
            Pvz:
            > Iveskite teksta:
            _ ' as mokausi      '
            > Pradžioje yra tarpų: 1
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais + daug tarpu priekyje: ");
            string tekstasSuTarpaisPriekyje = Console.ReadLine();

            int kiekPriekyjeTarpu = SkaiciuojamPriekyjeWhitespace(tekstasSuTarpaisPriekyje);
            Console.WriteLine($"Gale yra {kiekPriekyjeTarpu} tarpu");

            #endregion

            #region 9
            // ==============================================================================
            /* 9
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti betkokį tekstą Main metode.
            - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
            <hint> naudoti out
            - Main į ekraną išveda rezultatą
            Pvz:
            > Iveskite teksta:
            _ ' as mokausi      '
            > Pradžioje yra tarpų: 1
            > Gale yra tarpų: 6
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais + daug tarpu priekyje IR gale: ");
            string tekstasSuTarpaisPriekyjeIrGale = Console.ReadLine();

            int tarpaiPriekyje = SkaiciuojamTarpusPriekyjeIrGale(tekstasSuTarpaisPriekyjeIrGale, out int tarpaiGale);

            Console.WriteLine($"Priekyje yra {tarpaiPriekyje} tarpai, o gale yra {tarpaiGale} tarpai");

            #endregion

            #region 10
            // ==============================================================================
            /* 10
            Parašykite programą kurioje yra vienas metodas.
            - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
            - Main metode į ekraną išveskite metodo darbo rezultatą
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > 'a' raidžių kiekis yra: 3
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais: ");
            string tekstasSuA = Console.ReadLine();
            int kiekYraRaidziuA = SuskaiciuojamRaidesA(tekstasSuA);
            Console.WriteLine($"Rasta {kiekYraRaidziuA} mazuju a raidziu");

            #endregion

            #region 11A
            // ==============================================================================
            /*
            Parašykite programą kurioje vienas metodas. 
            - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
            Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
            N.B. grąžinama string, o ne bool.
            -  Išvesti rezultatą Main metode.
            Pvz: 
            > Iveskite teksta:
            _ ' as labai mokausi programuoti     '
            > Ar yra mokausi: Taip

            Pvz: 
            > Iveskite teksta:
            _ ' as_labai_mokausi_programuoti     '
            > Ar yra mokausi: Ne
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais: ");
            string text = Console.ReadLine();
            string taipArNe = ArYraZodisMokausi(text);
            Console.WriteLine($"Ar yra mokausi zodis: {taipArNe}");

            #endregion

            #region 12
            // ==============================================================================
            /*
            Parašykite programą kurioje yra vienas metodas.
            - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
            - Main metode į ekraną išveskite metodo darbo rezultatą
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > 'a' raides vieta yra: 0
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais: ");
            string text12 = Console.ReadLine();
            int raidesAvieta = raidesAVieta(text);
            Console.WriteLine($"Pirmos raides a vienat tekste: {raidesAvieta}");

            #endregion
        }

        #region Methods
        public static int raidesAVieta(string text)
        {
            return text.IndexOf("a");
        }

        public static string ArYraZodisMokausi(string text)
        {
            bool isMokausi = text.Contains("mokausi");
            int indexOfMokausi = text.IndexOf("mokausi");
            int lengthOfText = text.Length;
            string zodis = "mokausi";

            bool isIeskomasZodisPriekyje = text.Contains("" + zodis + " ") ||
                                           text.Contains("" + zodis + ", ") ||
                                           text.Contains("(" + zodis + ") ");

            bool isIeskomasZodisViduryje = text.Contains(" " + zodis + " ") ||
                                           text.Contains(" " + zodis + ", ") ||
                                           text.Contains(" (" + zodis + ") ");

            bool isIeskomasZodisGale = text.Contains(" " + zodis + "") ||
                                       text.Contains(" " + zodis + ".") ||
                                       text.Contains(" " + zodis + "!") ||
                                       text.Contains(" " + zodis + "?") ||
                                       text.Contains(" (" + zodis + ")");

            if (isMokausi && indexOfMokausi == 0 && isIeskomasZodisPriekyje && lengthOfText >= 8)
                return "Taip";
            else if (isMokausi && indexOfMokausi > 0 && isIeskomasZodisViduryje && lengthOfText >= 9)
                return "Taip";
            else if (isMokausi && indexOfMokausi > 0 && isIeskomasZodisGale && lengthOfText - indexOfMokausi <= 8)
                return "Taip";
            else if (isMokausi && lengthOfText == 7)
                return "Taip";
            else
            return "Ne";
        }

        public static int SuskaiciuojamRaidesA(string text)
        {
            return text.Length - text.Replace("a", "").Length;
        }

        public static int SkaiciuojamTarpusPriekyjeIrGale(string tekstas, out int tg)
        {
            tg = tekstas.Length - tekstas.TrimEnd().Length;

            return tekstas.Length - tekstas.TrimStart().Length;
        }

        public static int SkaiciuojamGaloWhitespace(string t)
        {
            return t.Length - t.TrimEnd().Length;
        }
        public static int SkaiciuojamPriekyjeWhitespace(string t)
        {
            return t.Length - t.TrimStart().Length;
        }

        public static int SkaiciuojamZodzius(string tekstas)
        {
            //return tekstas.Trim().Length - tekstas.Trim().Replace(" ", "").Length + 1;
            return tekstas.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int SkaiciuojamTarpus(string tekstasSuTarpais, int x)
        {
            if (x == 1)
            {
                int ats = tekstasSuTarpais.Length - tekstasSuTarpais.Replace(" ", "").Length;
                return ats;
            }
            else
            {
                return tekstasSuTarpais.Trim().Length;
            }
        }

        public static void MatematineSuma(int intSkA1, int intSkA2)
        {
            Console.Write($"{intSkA1} + {intSkA2} = {intSkA1 + intSkA2}");
        }

        public static string sveikiSuVardu()
        {
            Console.Write("Iveskite savo varda: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Sveiki {name}");
            return name;
        }

        public static void ikiSuVardu(string name)
        {
            Console.WriteLine($"{name}, linkiu jums geros dienos");
        }

        public static void sveiki()
        {
            Console.WriteLine("Sveiki visi");
        }

        public static void iki()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }
        #endregion

    }
}