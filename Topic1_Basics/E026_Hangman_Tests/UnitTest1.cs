namespace E026_Hangman_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PickRandomWordFromSelectedTopicAndRemoveIt_Test()
        {
            E026_Hangman.Program.selectedTopic = 1;
            E026_Hangman.Program.names = new Dictionary<string, int> { { "Jonas", 1 } };
            string fakeSelectedWord = "Jonas";
            string actualSelectedWord = E026_Hangman.Program.PickRandomWordFromSelectedTopicAndRemoveIt(new Random());
            Assert.AreEqual(fakeSelectedWord, actualSelectedWord);
        }

        [TestMethod]
        public void FormGuessList_Test()
        {
            List<string> fake = new List<string> { "_", "_", "_", "_", "_" };
            List<string> actual = E026_Hangman.Program.FormGuessList("Jonas", false);
            CollectionAssert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void FormGuessList_Test1()
        {
            List<string> fake = new List<string> { "J", "o", "n", "a", "s" };
            List<string> actual = E026_Hangman.Program.FormGuessList("Jonas", true);
            CollectionAssert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void IsAllowedGuess_Test()
        {
            bool fake = true;
            bool actual = E026_Hangman.Program.IsAllowedGuess("j");
            Assert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void IsAllowedGuess_Test1()
        {
            bool fake = true;
            bool actual = E026_Hangman.Program.IsAllowedGuess("Jonas");
            Assert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void IsAllowedGuess_Test2()
        {
            bool fake = false;
            bool actual = E026_Hangman.Program.IsAllowedGuess("q");
            Assert.AreEqual(fake, actual);
        }

        [TestMethod]
        public void IsAllowedGuess_Test3()
        {
            bool fake = false;
            bool actual = E026_Hangman.Program.IsAllowedGuess("Jonas123");
            Assert.AreEqual(fake, actual);
        }

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
            E026_Hangman.Program.guessedCorrectLetters = new List<string> { "J", "o", "_", "a", "s" };
            E026_Hangman.Program.IsGuessCorrect("v");
            Assert.AreEqual(E026_Hangman.Program.victory, false);
        }

        [TestMethod]
        public void IsGuessCorrect_Test2()
        {
            E026_Hangman.Program.selectedWord = "Jonas";
            E026_Hangman.Program.guessedWrongLetters = new List<string> { "z", "c", "b" };
            E026_Hangman.Program.guessedCorrectLetters = new List<string> { "J", "o", "_", "a", "s" };
            E026_Hangman.Program.IsGuessCorrect("v");
            CollectionAssert.AreEqual(E026_Hangman.Program.guessedWrongLetters, new List<string> { "z", "c", "b", "v" });
        }
    }
}