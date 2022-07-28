using System.Text;

//Encoding.GetEncoding(1257);

namespace E026_Hangman
{
    public class Program
    {
        public static string[] topics = new string[] { "Vardai", "Lietuvos miestai", "Šalys", "Spalvos" };
        public static Dictionary<string, int> names = new Dictionary<string, int>
            {
                { "Rūta", 1 },
                { "Petras", 2 },
                { "Antanas", 3 },
                { "Saulius", 4 }
            };
        public static Dictionary<string, int> cities = new Dictionary<string, int>
            {
                { "Vilnius", 1 },
                { "Kaunas", 2 },
                { "Klaipėda", 3 },
                { "Šiauliai", 4 }
            };
        public static Dictionary<string, int> countries = new Dictionary<string, int>
            {
                { "Lietuva", 1 },
                { "Latvija", 2 },
                { "Estija", 3 },
                { "Lenkinja", 4 }
            };
        public static Dictionary<string, int> colors = new Dictionary<string, int>
            {
                { "Volkswagen", 1 },
                { "Toyota", 2 },
                { "Porsche", 3 },
                { "BMW", 4 }
            };

        public static int hangmanProgress = 0;      // 7 is max
        public static int? selectedTopic = null;    // 4 is max
        public static string stringTopic = "";
        public static string selectedWord = "";
        public static string message = "";
        public static List<string> guessedWrongLetters = new List<string>();
        public static List<string> guessedCorrectLetters = new List<string>();
        public static bool victory = false;

        static void Main(string[] args)
        {
            PlayHangman();
        }

        private static void Testing()
        {
            Console.WriteLine($"          Topics: {string.Join(", ", topics)}");
            Console.WriteLine($"           Names: {string.Join(", ", names)}");
            Console.WriteLine($"          Cities: {string.Join(", ", cities)}");
            Console.WriteLine($"       Countries: {string.Join(", ", countries)}");
            Console.WriteLine($"      Car brands: {string.Join(", ", colors)}");
            Console.WriteLine($"  Selected topic: {selectedTopic}");
            Console.WriteLine($"   Selected word: {selectedWord}");
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void PlayHangman()
        {
            GiveTopics();

            selectedTopic = IntTryParseOutNull(Console.ReadLine());
            while (selectedTopic == null || selectedTopic < 0 || selectedTopic > 4)
            {
                Console.Write("Blogas pasirinkimas, bangykite dar karta: ");
                selectedTopic = IntTryParseOutNull(Console.ReadLine());
            }

            Random rand = new Random();
            selectedWord = PickRandomWordFromSelectedTopicAndRemoveIt(rand);
            guessedCorrectLetters = FormGuessList(selectedWord);

            while (hangmanProgress != 7 && !victory)
            {

                Console.Clear();
                Testing();
                Console.WriteLine();

                ShowTopicSelected();

                DrawHangman(hangmanProgress);

                //ShowMessage();


                Console.Write("Spekite raidę arba visą žodį: ");

                string letterOrWord = EnterLetterOrWord();
                Guessing(letterOrWord);
            }

            if (hangmanProgress == 7)
               message = "JŪS PRALAIMEJOTE! :(";

            if (victory)
                message = "JŪS LAIMEJOTE! :)";


            ShowTopicSelected();
            DrawHangman(hangmanProgress);


            string choice = "";
            do
            {
                Console.Write("\nŽaisti dar kartą (T/N)? ");
                choice = Console.ReadLine().ToUpper();
            }
            while (!(choice == "T" || choice == "N"));

            if (choice == "T")
            {
                Reset();
                PlayHangman();
            }
        }

        private static void GiveTopics()
        {
            Console.WriteLine("Pasirinkite tema: ");
            int counter = 1;
            foreach (string topic in topics)
            {
                Console.WriteLine($"{counter}. {topic}");
                counter++;
            }
        }

        public static int? IntTryParseOutNull(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

        public static string PickRandomWordFromSelectedTopicAndRemoveIt(Random rand)
        {
            string removedWord = "";

            if (selectedTopic == 1 && names.Count() != 0)
            {
                stringTopic = "Vardai";
                removedWord = RandomKeyInDictionary(rand, names);
                names.Remove(removedWord);
            }
            else if (selectedTopic == 2 && cities.Count() != 0)
            {
                stringTopic = "Lietuvos miestai";
                removedWord = RandomKeyInDictionary(rand, cities);
                cities.Remove(removedWord);
            }
            else if (selectedTopic == 3 && countries.Count() != 0)
            {
                stringTopic = "Salys";
                removedWord = RandomKeyInDictionary(rand, countries);
                countries.Remove(removedWord);
            }
            else if (selectedTopic == 4 && colors.Count() != 0)
            {
                stringTopic = "Spalvos";
                removedWord = RandomKeyInDictionary(rand, colors);
                colors.Remove(removedWord);
            }
            else
            {
                Reset();
                Console.WriteLine($"Pasirinta tema yra tuscia!");
                PlayHangman();
            }

            return removedWord;
        }

        public static string RandomKeyInDictionary(Random rand, Dictionary<string, int> Dict)
        {
            List<string> dictionaryKeys = new List<string>(Dict.Keys);
            int randomIndex = rand.Next(dictionaryKeys.Count);
            string randomKey = dictionaryKeys[randomIndex];
            return randomKey;
        }

        private static List<string> FormGuessList(string word)
        {
            List<string> list = new List<string>();
            foreach (char w in word)
            {
                list.Add("_");
            }
            return list;
        }

        private static void ShowTopicSelected()
        {
            Console.WriteLine(" ┌─────────────────────────────────────────────────────┐");
            Console.WriteLine(" │                     “Kartuves”                      │");
            Console.WriteLine($" │                  Tema:{stringTopic,-30}│");
            Console.WriteLine(" ╞═════════════════════════════════════════════════════╡");
        }

        public static void DrawHangman(int hangmanProgress)
        {
            //    │    ├ ┤    ─    ┌ ┐ └ ┘           ┴ ┬ ┼

            string wrongLetters = $"Neteisingos raides: {string.Join(" ", guessedWrongLetters)}";
            string correctLetters = $"Atspek zodi: {string.Join(" ", guessedCorrectLetters)}";

            Console.WriteLine(" │                                          ╔════╕     │");
            switch (hangmanProgress)
            {
                case 0:
                    Console.WriteLine(" │                                          ║          │");
                    Console.WriteLine($" │  {wrongLetters,-37}   ║          │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║          │");
                    Console.WriteLine(" │                                          ║          │");
                    break;
                case 1:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  { wrongLetters,-37}   ║          │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║          │");
                    Console.WriteLine(" │                                          ║          │");
                    break;
                case 2:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  {wrongLetters,-37}   ║    ☺     │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║          │");
                    Console.WriteLine(" │                                          ║          │");
                    break;
                case 3:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  { wrongLetters,-37}   ║    ☺     │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║    O     │");
                    Console.WriteLine(" │                                          ║          │");
                    break;
                case 4:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  {wrongLetters,-37}   ║    ☺     │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║   /O     │");
                    Console.WriteLine(" │                                          ║          │");
                    break;
                case 5:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  {wrongLetters,-37}   ║    ☺     │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║   /O\\    │");
                    Console.WriteLine(" │                                          ║          │");
                    break;
                case 6:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  {wrongLetters,-37}   ║    ☺     │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║   /O\\    │");
                    Console.WriteLine(" │                                          ║   /      │");
                    break;
                case 7:
                    Console.WriteLine(" │                                          ║    |     │");
                    Console.WriteLine($" │  {wrongLetters,-37}   ║    ☻     │");
                    Console.WriteLine($" │  {correctLetters,-37}   ║   /O\\    │");
                    Console.WriteLine(" │                                          ║   / \\    │");
                    break;
            }
            Console.WriteLine(" │                                          ║          │");
            Console.WriteLine(" ╞══════════════════════════════════════════╩══════════╡");
        }

        public static string EnterLetterOrWord()
        {
            Console.Write("Spekite raide arba visa zodi is karto: ");
            string letterOrWord = Console.ReadLine();
            
            while (!isAllowedGuess(letterOrWord))   
            {
                Console.Write("Speti galima tik lietuviska raide arba zodi tik is lietuvisku raidziu: ");
                letterOrWord = Console.ReadLine();
            }

            return letterOrWord;
        }

        public static bool isAllowedGuess(string? letterOrWord)
        {
            string allowedLetters = "AaĄąBbCcČčDdEeĘęĖėFfGgHhIiĮįYyJjKkLlMmNnOoPpRrSsŠšTtUuŲųŪūVvZzŽž";
            if (letterOrWord.Length == 1 && allowedLetters.Contains(letterOrWord))
            {
                return true;
            }
            else if (letterOrWord.Length > 1)
            {
                bool isAllLettersAllowed = true;
                foreach (var letter in letterOrWord)
                {
                    if (!allowedLetters.Contains(letter))
                    {
                        isAllLettersAllowed = false;
                    }
                }
                if (isAllLettersAllowed)
                {
                    return true;
                }
            }
            return false;
        }

        private static void Guessing(string letterOrWord)
        {
            //Console.WriteLine($"Neteisingai spetos raides: {string.Join(" ", guessedWrongLetters)}");
            //Console.WriteLine($"Zodis - {string.Join(" ", guessedCorrectLetters)}.");

            if (letterOrWord.Length == 1)
            {
                if (!guessedWrongLetters.Contains(letterOrWord))
                {
                    if (selectedWord.ToLower().Contains(letterOrWord))
                    {
                        for (int i = 0; i < selectedWord.Length; i++)
                        {
                            if (selectedWord[i].ToString().ToLower() == letterOrWord)
                            {
                                if (i != 0)
                                    guessedCorrectLetters[i] = letterOrWord;
                                else
                                    guessedCorrectLetters[i] = letterOrWord.ToUpper();

                                if (!guessedCorrectLetters.Contains("_"))
                                    victory = true;
                            }
                        }
                    }
                    else
                    {
                        guessedWrongLetters.Add(letterOrWord);
                        hangmanProgress++;
                    }
                }
            }
            else if (letterOrWord.Length > 1)
            {
                if (selectedWord.ToLower() == letterOrWord)
                {
                    victory = true;
                }
                else
                    hangmanProgress = 7;
            }
            else
                Console.WriteLine("Neivedete nei raides, nei zodzio!");
        }

        private static void Reset()
        {
            Console.Clear();
            hangmanProgress = 0;
            selectedTopic = null;
            stringTopic = "";
            selectedWord = "";
            message = "";
            guessedWrongLetters = new List<string>();
            guessedCorrectLetters = new List<string>();
            victory = false;
        }











    }
}