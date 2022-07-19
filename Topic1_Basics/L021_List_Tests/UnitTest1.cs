namespace L021_List_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1_Test()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = L021_List.Program.Task1(fake);
            Assert.AreEqual(expected, actual);

        }
    }
}