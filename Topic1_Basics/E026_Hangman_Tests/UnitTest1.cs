namespace E026_Hangman_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RandomKeyInDictionary_Test()
        {
            E026_Hangman.Program.intSelectedTopic = 1;
            E026_Hangman.Program.names = new Dictionary<string, int> { { "Jonas", 1 } };
            string actualSelectedWord = E026_Hangman.Program.RandomKeyInDictionary(E026_Hangman.Program.names);
            Assert.AreEqual(actualSelectedWord, "Jonas");
        }

        [TestMethod]
        public void FormGuessList_Test()
        {
            E026_Hangman.Program.victory = false;
            List<string> fake = new List<string> { "_", "_", "_", "_", "_" };
            List<string> actual = E026_Hangman.Program.FormGuessList("Jonas");
            CollectionAssert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void FormGuessList_Test1()
        {
            E026_Hangman.Program.victory = true;
            List<string> fake = new List<string> { "J", "o", "n", "a", "s" };
            List<string> actual = E026_Hangman.Program.FormGuessList("Jonas");
            CollectionAssert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void IsAllowedGuess_Test() => Assert.AreEqual(E026_Hangman.Program.IsAllowedGuess("j"), true);
        
        [TestMethod]
        public void IsAllowedGuess_Test1() => Assert.AreEqual(E026_Hangman.Program.IsAllowedGuess("Jonas"), true);
       
        [TestMethod]
        public void IsAllowedGuess_Test2() => Assert.AreEqual(E026_Hangman.Program.IsAllowedGuess("q"), false);
        
        [TestMethod]
        public void IsAllowedGuess_Test3() => Assert.AreEqual(E026_Hangman.Program.IsAllowedGuess("Jonas123"), false);

        [TestMethod]
        public void IsGuessCorrect_Test()
        {
            E026_Hangman.Program.selectedWord = "Jonas";
            E026_Hangman.Program.guessedWrongLetters = new List<string> { "z", "c", "b" };
            E026_Hangman.Program.guessedCorrectLetters = new List<string> { "J", "o", "_", "a", "s" };
            E026_Hangman.Program.IsGuessCorrect("n");
            Assert.AreEqual(E026_Hangman.Program.victory, true);
        }

        [TestMethod]
        public void IsGuessCorrect_Test1()
        {
            E026_Hangman.Program.selectedWord = "Jonas";
            E026_Hangman.Program.guessedWrongLetters = new List<string> { "z", "c", "b" };
            E026_Hangman.Program.IsGuessCorrect("v");
            CollectionAssert.AreEqual(E026_Hangman.Program.guessedWrongLetters, new List<string> { "z", "c", "b", "v" });
        }
    }
}