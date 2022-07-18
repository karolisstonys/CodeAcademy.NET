namespace L020_Repeating_arrays_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1FindSmallestNumber_Test()
        {
            int[] fake = { 5, 3, 7, 6, 8, 7, 10, 0 };
            int expected = 0;
            var actual = L020_Repeating_arrays.Program.Task1FindSmallestNumber(fake);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Task2FindLargestNumber_Test()
        {
            int[] fake = { 5, 3, 7, 6, 8, 7, 10 };
            int expected = 10;
            var actual = L020_Repeating_arrays.Program.Task2FindLargestNumber(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3Ascending_Test()
        {
            int[] fake = { 5, 1, 7, 6, 8, 7, 10 };
            int[] expected = { 1, 5, 6, 7, 7, 8, 10 };
            var actual = L020_Repeating_arrays.Program.Task3Ascending(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}