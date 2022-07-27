namespace E026_Hangman
{
    public class Program
    {
        public static int hangmanProgress = 0; // 7 is max
        public static string[] topics = new string[] { "Vardai", "Lietuvos miestai", "Salys", "Automobiliu gamintojai" };
        public static Dictionary<string, int> names = new Dictionary<string, int>
            {
                { "Jonas", 1 },
                { "Petras", 2 },
                { "Antanas", 3 },
                { "Saulius", 4 }
            };
        public static Dictionary<string, int> cities = new Dictionary<string, int>
            {
                { "Vilnius", 1 },
                { "Kaunas", 2 },
                { "Klaipeda", 3 },
                { "Siauliai", 4 }
            };
        public static Dictionary<string, int> countries = new Dictionary<string, int>
            {
                { "Lietuva", 1 },
                { "Latvija", 2 },
                { "Estija", 3 },
                { "Lenkinja", 4 }
            };
        public static Dictionary<string, int> carBrands = new Dictionary<string, int>
            {
                { "Volkswagen", 1 },
                { "Toyota", 2 },
                { "Porsche", 3 },
                { "BMW", 4 }
            };
        public static int? selectedTopic = null;
        public static string selectedWord = "";
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
                GuessLetter();
            }

            if (hangmanProgress == 7)
                Console.WriteLine("JUS PRALAIMEJOTE!");

            if (victory)
                Console.WriteLine("JUS LAIMEJOTE!");

            string choise = "";
            do
            {
                Console.WriteLine("Bandyti dar karta? (T/N)");
                choise = Console.ReadLine().ToUpper();
            }
            while (!(choise == "T" || choise == "N"));

            if (choise == "T")
            {
                Reset();
                Console.Clear();
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

            if (selectedTopic == 1)
            {
                if (names.Count() != 0)
                {
                    removedWord = RandomKeyInDictionary(rand, names);
                    names.Remove(removedWord);
                }
                else
                {
                    Reset();
                    Console.Clear();
                    Console.WriteLine($"Pasirinta tema yra tuscia!");
                    PlayHangman();
                }
            }
            else if (selectedTopic == 2)
            {
                if (cities.Count() != 0)
                {
                    removedWord = RandomKeyInDictionary(rand, cities);
                    cities.Remove(removedWord);
                }
                else
                {
                    Reset();
                    Console.Clear();
                    Console.WriteLine($"Pasirinta tema yra tuscia!");
                    PlayHangman();
                }
            }
            else if (selectedTopic == 3)
            {
                if (countries.Count() != 0)
                {
                    removedWord = RandomKeyInDictionary(rand, countries);
                    countries.Remove(removedWord);
                }
                else
                {
                    Reset();
                    Console.Clear();
                    Console.WriteLine($"Pasirinta tema yra tuscia!");
                    PlayHangman();
                }
            }
            else if (selectedTopic == 4)
            {
                if (carBrands.Count() != 0)
                {
                    removedWord = RandomKeyInDictionary(rand, carBrands);
                    carBrands.Remove(removedWord);
                }
                else
                {
                    Reset();
                    Console.Clear();
                    Console.WriteLine($"Pasirinta tema yra tuscia!");
                    PlayHangman();
                }
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

        public static void DrawHangman(int duh)
        {
            if (duh == 0)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 1)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 2)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 3)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║    O   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 4)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║   /O   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 5)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║   /O\\  ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 6)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║   /O\\  ");
                Console.WriteLine(" ║   /    ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 7)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☻   ");
                Console.WriteLine(" ║   /O\\  ");
                Console.WriteLine(" ║   / \\  ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }







        }

        private static void GuessLetter()
        {
            Console.Clear();
            DrawHangman(hangmanProgress);

            Console.WriteLine($"Neteisingai spetos raides: {string.Join(" ", guessedWrongLetters)}");
            Console.WriteLine($"Zodis - {string.Join(" ", guessedCorrectLetters)}.");

            Console.Write("Spekite raide arba visa zodi: ");

            string letterOrWord = Console.ReadLine().ToLower();

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
            hangmanProgress = 0;
            selectedTopic = null;
            selectedWord = "";
            guessedWrongLetters = new List<string>();
            guessedCorrectLetters = new List<string>();
            victory = false;
        }











    }
}