using Microsoft.VisualStudio.TestTools.UnitTesting;
using L051_LINQ_Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L051_LINQ_Query_Tests
{
    [TestClass()]
    public class Program_Tests
    {
        [TestMethod()]
        public void Task2_Test()
        {
            //Arrange
            var list = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var expected = new List<int> { 1, 3, 12, 19, 6, 9, 10, 14 };
            //Act
            var actual = Program.Task2(list);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task3_Test()
        {
            //Arrange
            var list = new List<int> { 3, 9, 2, 8, 6, 5 };
            var expected = new List<int> { 9, 81, 4, 64, 36, 25 };
            //Act
            var actual = Program.Task3(list);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}