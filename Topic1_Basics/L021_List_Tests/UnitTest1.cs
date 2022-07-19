namespace L021_List_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1A_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = L021_List.Program.Task1A(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1B_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = L021_List.Program.Task1B(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2A_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            int[] expected = { 5, 1, 6, 8, 7, 9 };
            var actual = L021_List.Program.Task2A(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2B_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            List<int> expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = L021_List.Program.Task2B(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}