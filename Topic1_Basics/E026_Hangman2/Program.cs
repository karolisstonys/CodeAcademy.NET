using System.Text;

namespace E026_Hangman2
{
    public class Program
    {
        public static string[] topics = new string[] { "Vardai", "Lietuvos miestai", "Šalys", "Šunų veislės" };
        public static Dictionary<string, int> names = new Dictionary<string, int>
            {
                { "Jonas", 1 },
                { "Ona", 2 },
                { "Vytautas", 3 },
                { "Irena", 4 },
                { "Antanas", 5 },
                { "Janina", 6 },
                { "Tomas", 7 },
                { "Kristina", 8 },
                { "Juozas", 9 },
                { "Danutė", 10 }
            };
        public static Dictionary<string, int> cities = new Dictionary<string, int>
            {
                { "Vilnius", 1 },
                { "Kaunas", 2 },
                { "Klaipėda", 3 },
                { "Šiauliai", 4 },
                { "Panevėžys", 5 },
                { "Alytus", 6 },
                { "Marijampolė", 7 },
                { "Mažeikiai", 8 },
                { "Jonava", 9 },
                { "Utena", 10 }
            };
        public static Dictionary<string, int> countries = new Dictionary<string, int>
            {
                { "Lietuva", 1 },
                { "Latvija", 2 },
                { "Estija", 3 },
                { "Lenkija", 4 },
                { "Danija", 5 },
                { "Graikija", 6 },
                { "Italija", 7 },
                { "Kanada", 8 },
                { "Norvegija", 9 },
                { "Suomija", 10 }
            };
        public static Dictionary<string, int> dogBreads = new Dictionary<string, int>
            {
                { "Biglis", 1 },
                { "Buldogas", 2 },
                { "Pudelis", 3 },
                { "Taksas", 4 },
                { "Rotveileris", 5 },
                { "Mopsas", 6 },
                { "Senbernaras", 7 },
                { "Dobermanas", 8 },
                { "Dalmantinas", 9 },
                { "Čihuahua", 10 }
            };

        public static int hangmanProgress = 0;
        public static int? intSelectedTopic = null;
        public static string selectedTopic = "";
        public static string selectedWord = "";
        public static string message1 = "";
        public static string message2 = "";
        public static List<string> guessedWrongLetters = new List<string>();
        public static List<string> guessedCorrectLetters = new List<string>();
        public static bool victory = false;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            PlayHangman();
        }

        private static void PlayHangman()
        {
            GiveTopics();

            // Topic selection
            if (intSelectedTopic == null)
                intSelectedTopic = IntTryParseOutNull(Console.ReadLine());
            while (intSelectedTopic == null || intSelectedTopic < 1 || intSelectedTopic > 4)
            {
                Console.Write("Blogas pasirinkimas, bandykite dar kartą: ");
                intSelectedTopic = IntTryParseOutNull(Console.ReadLine());
            }

            // Picking & removing random word from selected topic if that topic is not empty
            if (intSelectedTopic == 1 && names.Count() != 0)
                GetRandomKeyFromDictionaryAndRemoveIt(names);
            else if (intSelectedTopic == 2 && cities.Count() != 0)
                GetRandomKeyFromDictionaryAndRemoveIt(cities);
            else if (intSelectedTopic == 3 && countries.Count() != 0)
                GetRandomKeyFromDictionaryAndRemoveIt(countries);
            else if (intSelectedTopic == 4 && dogBreads.Count() != 0)
                GetRandomKeyFromDictionaryAndRemoveIt(dogBreads);
            else
                GiveWarningSellectedTopicIsEmpty();

            // Some display information
            selectedTopic = topics[intSelectedTopic.Value - 1];
            guessedCorrectLetters = FormGuessList(selectedWord);

            // Guessing letter or word
            while (!IsGameOver() && !victory)
            {
                DrawHangman(hangmanProgress);
                string letterOrWord = EnterLetterOrWord();
                CheckIfGuessIsCorrect(letterOrWord.ToLower());
            }

            // Result & play again option
            DrawHangman(hangmanProgress);
            PlayAgain();
        }

        private static void GiveWarningSellectedTopicIsEmpty()
        {
            Reset();
            Console.WriteLine($"Pasirinta tema yra tusčia!");
            PlayHangman();
        }

        private static void GetRandomKeyFromDictionaryAndRemoveIt(Dictionary<string, int> dict)
        {
            selectedWord = SelectKeyInDictionary(dict, GiveRandomNumberUpToGiven(GetMaxIndexInDictonary(dict)));
            RemoveItemFromDIctionary(dict);
        }

        private static void RemoveItemFromDIctionary(Dictionary<string, int> dict) => dict.Remove(selectedWord);

        private static void GiveTopics()
        {
            Console.WriteLine("Temos");
            int counter = 1;
            foreach (string topic in topics)
            {
                Console.WriteLine($"{counter}. {topic}");
                counter++;
            }
            Console.Write("Pasirinkite temą: ");
        }

        private static int? IntTryParseOutNull(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

        public static int GetMaxIndexInDictonary(Dictionary<string, int> dict) => dict.Count;

        public static int GiveRandomNumberUpToGiven(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }

        public static string SelectKeyInDictionary(Dictionary<string, int> dict, int randomIndex)
        {
            List<string> dictionaryKeys = new List<string>(dict.Keys);
            return dictionaryKeys[randomIndex];
        }

        public static List<string> FormGuessList(string word)
        {
            List<string> list = new List<string>();
            foreach (char w in word)
            {
                if (victory)
                    list.Add(w.ToString());
                else
                    list.Add("_");
            }
            return list;
        }

        private static void DrawHangman(int hangmanProgress)
        {
            Console.Clear();
            Console.WriteLine(" ┌─────────────────────────────────────────────────────┐");
            Console.WriteLine(" │                     “Kartuvės”                      │");
            Console.WriteLine($" │                  Tema:{selectedTopic,-30}│");
            Console.WriteLine(" ╞═════════════════════════════════════════════════════╡");

            string wrongLetters = $"Neteisingos raidės: {string.Join(" ", guessedWrongLetters)}";
            string correctLetters = $"Atspėk žodį: {string.Join(" ", guessedCorrectLetters)}";

            string line1 = "";
            string line2 = "";
            string line3 = "";
            string line4 = "";
            switch (hangmanProgress)
            {
                case 0:
                    line1 =  " ";
                    line2 =  " ";
                    line3 = "   ";
                    line4 = "   ";
                    break;
                case 1:
                    line1 =  "│";
                    line2 =  " ";
                    line3 = "   ";
                    line4 = "   ";
                    break;
                case 2:
                    line1 =  "│";
                    line2 =  "☻";
                    line3 = "   ";
                    line4 = "   ";
                    break;
                case 3:
                    line1 =  "│";
                    line2 =  "☻";
                    line3 = " O ";
                    line4 = "   ";
                    break;
                case 4:
                    line1 =  "│";
                    line2 =  "☻";
                    line3 = "/O ";
                    line4 = "   ";
                    break;
                case 5:
                    line1 =  "│";
                    line2 =  "☻";
                    line3 = "/O\\";
                    line4 = "   ";
                    break;
                case 6:
                    line1 =  "│";
                    line2 =  "☻";
                    line3 = "/O\\";
                    line4 = "/  ";
                    break;
                case 7:
                    line1 =  "│";
                    line2 =  "☺";
                    line3 = "/O\\";
                    line4 = "/ \\";
                    break;
            }

            Console.WriteLine(" │                                          ╔════╕     │");
            Console.WriteLine($" │  {message1,-37}   ║    {line1}     │");
            Console.WriteLine($" │  {message2,-37}   ║    {line2}     │");
            Console.WriteLine($" │  {wrongLetters,-37}   ║   {line3}    │");
            Console.WriteLine($" │  {correctLetters,-37}   ║   {line4}    │");
            Console.WriteLine(" │                                          ║          │");
            Console.WriteLine(" ╞══════════════════════════════════════════╩══════════╡");
        }

        private static string EnterLetterOrWord()
        {
            Console.WriteLine(" │  Spėkite raidę arba visą žodį iš karto:             │");
            Console.WriteLine(" └─────────────────────────────────────────────────────┘");
            Console.SetCursorPosition(43, 11);
            string letterOrWord = Console.ReadLine();

            while (!IsAllowedGuess(letterOrWord))
            {
                Console.SetCursorPosition(0, 11);
                Console.WriteLine(" │  Spėkite raidę arba visą žodį iš karto:             │");
                Console.WriteLine(" │  Spėjimui galima naudoti TIK lietuviškas raides!    │");
                Console.WriteLine(" └─────────────────────────────────────────────────────┘");

                Console.SetCursorPosition(43, 11);
                letterOrWord = Console.ReadLine();
            }

            return letterOrWord;
        }

        public static bool IsAllowedGuess(string? letterOrWord)
        {
            string allowedLetters = "AaĄąBbCcČčDdEeĘęĖėFfGgHhIiĮįYyJjKkLlMmNnOoPpRrSsŠšTtUuŲųŪūVvZzŽž";
            if (IsOneLetter(letterOrWord) && allowedLetters.Contains(letterOrWord))
            {
                return true;
            }
            else if (IsWord(letterOrWord))
            {
                bool isAllLettersAllowed = true;
                foreach (var letter in letterOrWord)
                {
                    if (!allowedLetters.Contains(letter))
                        isAllLettersAllowed = false;
                }
                if (isAllLettersAllowed)
                {
                    return true;
                }
            }
            return false;
        }

        public static void CheckIfGuessIsCorrect(string letterOrWord)
        {
            if (IsOneLetter(letterOrWord))
                CheckIfGuessedLetterIsCorrect(letterOrWord);
            else if (IsWord(letterOrWord))
                CheckIfGuessedWordIsCorrect(letterOrWord);
            else
                SetMessage(false, "Neįvedėte nei raidės, nei žodžio!", "");
        }

        private static bool IsOneLetter(string letterOrWord) => letterOrWord.Length == 1;

        private static bool IsWord(string letterOrWord) => letterOrWord.Length > 1;

        private static void CheckIfGuessedLetterIsCorrect(string letterOrWord)
        {
            if (IsLetterAlreadyGuessed(letterOrWord))
            {
                SetMessage(false, "Tokia raidė jau buvo spėta", "");
                return;
            }

            if (!IsLetterInSelectedWord(letterOrWord))
            {
                guessedWrongLetters.Add(letterOrWord);
                hangmanProgress++;
                if (IsGameOver())
                    SetMessage(false, "Pralaimėjote! Spėjimai baigėsi.", $"Žodis buvo - {selectedWord}");
                return;
            }

            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i].ToString().ToLower() == letterOrWord)
                {
                    if (i != 0)
                        guessedCorrectLetters[i] = letterOrWord;
                    else
                        guessedCorrectLetters[i] = letterOrWord.ToUpper();

                    if (!guessedCorrectLetters.Contains("_"))
                        SetMessage(true, "Sveikiname!!!", "Jūs atspėjote žodį.");
                }
            }
        }

        private static bool IsLetterAlreadyGuessed(string letter) => guessedWrongLetters.Contains(letter);

        private static bool IsLetterInSelectedWord(string letter) => selectedWord.ToLower().Contains(letter);

        private static void CheckIfGuessedWordIsCorrect(string word)
        {
            if (selectedWord.ToLower() == word)
            {
                SetMessage(true, "Sveikiname!", "Atspėjote visą žodį iš karto.");
                guessedCorrectLetters = FormGuessList(selectedWord);
            }
            else
            {
                hangmanProgress = 7;
                SetMessage(false, "Pralaimejėte! Atspėti žodžio nepyko.", $"Žodis buvo - {selectedWord}");
            }
        }

        private static void SetMessage(bool isVictory, string msg1, string msg2)
        {
            victory = isVictory;
            message1 = msg1;
            message2 = msg2;
        }

        private static bool IsGameOver() => hangmanProgress == 7;

        private static void PlayAgain()
        {
            string choice = "";
            do
            {
                Console.SetCursorPosition(0, 11);
                Console.WriteLine(" │  Žaisti dar kartą (T/N) ?                           │");
                Console.WriteLine(" └─────────────────────────────────────────────────────┘");
                Console.SetCursorPosition(29, 11);
                choice = Console.ReadLine().ToUpper();
            }
            while (!(choice == "T" || choice == "N"));

            if (choice == "T")
            {
                Reset();
                PlayHangman();
            }
            else
            {
                Console.SetCursorPosition(0, 11);
                Console.WriteLine(" │                                                ATE  │");
                Console.WriteLine(" └─────────────────────────────────────────────────────┘");
            }
        }

        private static void Reset()
        {
            Console.Clear();
            hangmanProgress = 0;
            intSelectedTopic = null;
            selectedTopic = "";
            selectedWord = "";
            message1 = "";
            message2 = "";
            guessedWrongLetters = new List<string>();
            guessedCorrectLetters = new List<string>();
            victory = false;
        }











    }
}