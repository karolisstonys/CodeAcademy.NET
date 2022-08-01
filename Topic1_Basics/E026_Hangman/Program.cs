using System.Text;

namespace E026_Hangman
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
                { "Danute", 10 }
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
                Console.OutputEncoding = Encoding.GetEncoding(1200);
                Console.Write("Blogas pasirinkimas, bandykite dar kartą: ");
                intSelectedTopic = IntTryParseOutNull(Console.ReadLine());
            }

            // Picking & removing random word from selected topic if that topic is not empty
            if (intSelectedTopic == 1 && names.Count() != 0)
            {
                selectedWord = RandomKeyInDictionary(names);
                names.Remove(selectedWord);
            }
            else if (intSelectedTopic == 2 && cities.Count() != 0)
            {
                selectedWord = RandomKeyInDictionary(cities);
                cities.Remove(selectedWord);
            }
            else if (intSelectedTopic == 3 && countries.Count() != 0)
            {
                selectedWord = RandomKeyInDictionary(countries);
                countries.Remove(selectedWord);
            }
            else if (intSelectedTopic == 4 && dogBreads.Count() != 0)
            {
                selectedWord = RandomKeyInDictionary(dogBreads);
                dogBreads.Remove(selectedWord);
            }
            else
            {
                Reset();
                Console.OutputEncoding = Encoding.GetEncoding(1200);
                Console.WriteLine($"Pasirinta tema yra tusčia!");
                PlayHangman();
            }

            // Some display information
            selectedTopic = topics[intSelectedTopic.Value - 1];
            guessedCorrectLetters = FormGuessList(selectedWord);

            // Guessing letter or word
            while (hangmanProgress != 7 && !victory)
            {
                DrawHangman(hangmanProgress);
                string letterOrWord = EnterLetterOrWord();
                IsGuessCorrect(letterOrWord.ToLower());
            }

            // Result & play again option
            DrawHangman(hangmanProgress);
            PlayAgain();            
        }

        private static void Testing()
        {
            Console.WriteLine($"          Topics: {string.Join(", ", topics)}");
            Console.WriteLine($"           Names: {string.Join(", ", names)}");
            Console.WriteLine($"          Cities: {string.Join(", ", cities)}");
            Console.WriteLine($"       Countries: {string.Join(", ", countries)}");
            Console.WriteLine($"      Car brands: {string.Join(", ", dogBreads)}");
            Console.WriteLine($"  Selected topic: ({intSelectedTopic}) {selectedTopic}");
            Console.WriteLine($"   Selected word: {selectedWord}");
        }

        private static void GiveTopics()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
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

        public static string RandomKeyInDictionary(Dictionary<string, int> Dict)
        {
            Random rand = new Random();
            List<string> dictionaryKeys = new List<string>(Dict.Keys);
            int randomIndex = rand.Next(dictionaryKeys.Count);
            string randomKey = dictionaryKeys[randomIndex];
            return randomKey;
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
            Console.OutputEncoding = Encoding.GetEncoding(1200);
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
                    line1 =  "|";
                    line2 =  " ";
                    line3 = "   ";
                    line4 = "   ";  
                    break;
                case 2:
                    line1 =  "|";
                    line2 =  "☻";
                    line3 = "   ";
                    line4 = "   "; 
                    break;
                case 3:
                    line1 =  "|";
                    line2 =  "☻";
                    line3 = " O ";
                    line4 = "   ";
                    break;
                case 4:
                    line1 =  "|";
                    line2 =  "☻";
                    line3 = "/O ";
                    line4 = "   ";
                    break;
                case 5:
                    line1 =  "|";
                    line2 =  "☻";
                    line3 = "/O\\";
                    line4 = "   "; 
                    break;
                case 6:
                    line1 =  "|";
                    line2 =  "☻";
                    line3 = "/O\\";
                    line4 = "/  ";
                    break;
                case 7:
                    line1 =  "|";
                    line2 =  "☺";
                    line3 = "/O\\";
                    line4 = "/ \\";
                    break;
            }

            Console.OutputEncoding = Encoding.GetEncoding(1200);
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
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            Console.WriteLine(" │  Spėkite raidę arba visą žodį iš karto:             |");
            Console.WriteLine(" └─────────────────────────────────────────────────────┘");
            Console.SetCursorPosition(43,11);
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

        public static void IsGuessCorrect(string letterOrWord)
        {
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
                                {
                                    victory = true;
                                    message1 = "Sveikiname!!!";
                                    message2 = "Jūs atspėjote žodį.";
                                }
                            }
                        }
                    }
                    else
                    {
                        guessedWrongLetters.Add(letterOrWord);
                        hangmanProgress++;
                        if (hangmanProgress == 7)
                        {
                            message1 = "Pralaimėjote! Spėjimai baigėsi.";
                            message2 = $"Žodis buvo - {selectedWord}";
                        }
                    }
                }
            }
            else if (letterOrWord.Length > 1)
            {
                if (selectedWord.ToLower() == letterOrWord)
                {
                    victory = true;
                    message1 = "Sveikiname!";
                    message1 = "Atspėjote visą žodį iš karto.";
                    guessedCorrectLetters = FormGuessList(selectedWord);
                }
                else
                {
                    hangmanProgress = 7;
                    message1 = "Pralaimejėte! Atspėti žodžio nepyko.";
                    message2 = $"Žodis buvo - {selectedWord}";
                }
            }
            else
                message1 = "Neįvedėte nei raidės, nei žodžio!";
        }

        private static void PlayAgain()
        {
            string choice = "";
            do
            {
                Console.SetCursorPosition(0, 11);
                Console.OutputEncoding = Encoding.GetEncoding(1200);
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