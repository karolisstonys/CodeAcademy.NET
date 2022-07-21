namespace L022_ForEach
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> cardTypes = new List<string> { "Sirdziu", "Bugnu", "Vynu", "Kryziu" };
            List<string> cards = new List<string> { "Tuzas", "Dviake", "Triake", "Keturake", "Penkake", "Sesake", "Septynake", 
                                                    "Astuonake", "Devynakės", "Desimtake", "Valetas", "Dama", "Karalius" };

            Console.WriteLine(string.Join("\n", Task6DeckSort(Task6BuildDeck(cardTypes, cards))));
        }

        private static void EXAMPLES()
        {
            int[] taskuMasyvas = new int[10];
            taskuMasyvas[0] = 1;
            foreach (var taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai} - naujas elementas!");
            }

            Console.WriteLine();

            string[] masinos = new string[] { "BMW", "Audi", "Toyota" };
            foreach (var masina in masinos)
            {
                Console.WriteLine(masina);
            }

            Console.WriteLine();

            List<int> amziai = new List<int> { 19, 20, 21 };
            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius: {amzius}");
            }

            List<string> vardai = new List<string> { "Jonas", "Petras", "Antanas" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"Vardas: {vardas}");
            }

            string sakinys = "Labas rytas stai ir as";
            foreach (var raide in sakinys)
            {
                Console.WriteLine(raide);
            }
        }

        #region KLASES DARBAS 1. Parasykite programa, kuri apskaiciuotu duoto integer saraso vidurki
        public static double Task1Average(List<int> li)
        {
            double average = 0;
            foreach (var num in li)
            {
                average += num;
            }
            return average / li.Count;
        }
        #endregion

        #region KLASES DARBAS 2. Parasykite metoda, kuris grazina ar skaicius neigiamas ar teigiamas masyve.
        public static List<string> Task2CheckIfPositive(List<int> li)
        {
            List<string> positivity = new List<string>();
            foreach (var num in li)
            {
                if (num >= 0)
                    positivity.Add("teigiamas");
                else
                    positivity.Add("neigiamas");
            }
            return positivity;
        }
        #endregion

        #region KLASES DARBAS 3. Parasykite metoda, kuris apskaiciuos kiek jums reikes sumoketi GPM nuo duoto imoku saraso. Sio uzdavinio GPM: 15%
        public static double Task3Tax(List<double> li)
        {
            double tax = 0;
            foreach (var item in li)
            {
                tax += item;
            }
            return tax * 0.15d;
        }
        #endregion

        /* 4. Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.
        Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string skaiciaiTekste" ir surikiuoja skaicius
        didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:
        PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255 */
        public static string Task4ExtractNumbers(string text)
        {
            string onlyNumbers = "";
            foreach (char character in text)
            {
                if (character >= 48 && character <= 57)
                    onlyNumbers += character;
            }
            return onlyNumbers;
        }

        public static string Task4Ascending(string text)
        {
            List<int> digits = new List<int>();
            foreach (char character in text)
            {
                digits.Add(character - 48);
            }

            for (int i = 0; i < digits.Count; i++)
            {
                for (int j = i + 1; j < digits.Count; j++)
                {
                    if (digits[j] < digits[i])
                    { 
                        int tempI = digits[i];
                        digits[i] = digits[j];
                        digits[j] = tempI;
                    }
                }
            }
            return String.Join("", digits);
        }

        /* 5. Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, 
        kurie ilgesni ARBA LYGUS nei 5 raides ir yra surikiuoti abeceles tvarka.
        Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.
        
        PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinis String.Split(' ')        
                                                                                      .sort()
        
                              PVZ: Ivedame: Labas as esu Kodelskis ir labai megstu programuoti
        Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti
        Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti */
        public static string[] Task5Split(string text) => text.Split(" ");

        public static string Task5JoinAndSort(string[] text, out string notSorted)
        {
            List<string> newListBelow5 = new List<string>();
            List<string> newListAbove5 = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString().Length >= 5)
                    newListAbove5.Add(text[i].ToString());
                else
                    newListBelow5.Add(text[i].ToString());
            }

            notSorted = string.Join(" ", newListBelow5) + " " + string.Join(" ", newListAbove5);
            newListAbove5.Sort();
            return string.Join(" ", newListBelow5) + " " + string.Join(" ", newListAbove5);
        }

        /* 6. Parašyti metodą SukonstruotiKalade(rusis, kortos). Sis metodas turi sukonstruoti kalade is duotu 2 string sarasu.        
              Po to parasyti metoda, kuris surikiuoja jusu kalade pagal abeceles tvarka.         <summary>
              Po to parasyti metoda, kuris surikiuoja jusu kalade pagal abeceles tvarka.  

              Ir galiausiai parasyti, kad jusu visas kortas atspausdintu ekrane.        
              PRIMINIMAS: 
        
        "Sirdziu",
        "Bugnu",
        "Vynu",
        "Kryziu"
        
        "Tuzas",
        "Dviake",
        "Triake",
        "Keturake",
        "Penkake",
        "Sesake",
        "Septynake",
        "Astuonake",
        "Devynakės",
        "Desimtake",
        "Valetas",
        "Dama",
        "Karalius"

        PVZ: Isvedimas - Bugnu Tuzas, Bugnu Dviake...Bugnu Dama, Bugnu Karalius... Kryziu Karalius
        */
        public static List<string> Task6BuildDeck(List<string> cardTypes, List<string> cards)
        {
            List<string> deck = new List<string>();

            foreach (string cardType in cardTypes)
            {
                foreach (var card in cards)
                {
                    deck.Add(cardType + " " + card);
                }
            }

            return deck;
        }

        public static List<string> Task6DeckSort(List<string> deck)
        {
            List<string> deckSorted = new List<string>();
            deckSorted.AddRange(deck);
            deckSorted.Sort();
            return deckSorted;
        }










    }
}