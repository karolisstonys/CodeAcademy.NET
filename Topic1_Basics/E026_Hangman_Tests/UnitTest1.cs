namespace E026_Hangman_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMaxIndexInDictonary_Test()
        {
            int maxIndex = E026_Hangman.Program.GetMaxIndexInDictonary(E026_Hangman.Program.names);
            Assert.AreEqual(maxIndex, 10);
        }

        [TestMethod]
        public void GiveRandomNumberUpToGiven_Test()
        {
            int randomLowerThanFive = E026_Hangman.Program.GiveRandomNumberUpToGiven(5);
            Assert.IsTrue(randomLowerThanFive < 5, "The randomLowerThanFive was not lower than five");
        }

        [TestMethod]
        public void SelectKeyInDictionary_Test()
        {
            string SelectedWord = E026_Hangman.Program.SelectKeyInDictionary(E026_Hangman.Program.names, 2);
            Assert.AreEqual(SelectedWord, "Vytautas");
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
        public void CheckIfGuessIsCorrect_Test()
        {
            E026_Hangman.Program.selectedWord = "Jonas";
            E026_Hangman.Program.guessedWrongLetters = new List<string> { "z", "c", "b" };
            E026_Hangman.Program.guessedCorrectLetters = new List<string> { "J", "o", "_", "a", "s" };
            E026_Hangman.Program.CheckIfGuessIsCorrect("n");
            Assert.AreEqual(E026_Hangman.Program.victory, true);
        }

        [TestMethod]
        public void CheckIfGuessIsCorrect_Test1()
        {
            E026_Hangman.Program.selectedWord = "Jonas";
            E026_Hangman.Program.guessedWrongLetters = new List<string> { "z", "c", "b" };
            E026_Hangman.Program.CheckIfGuessIsCorrect("v");
            CollectionAssert.AreEqual(E026_Hangman.Program.guessedWrongLetters, new List<string> { "z", "c", "b", "v" });
        }
    }
}