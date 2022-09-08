using Microsoft.VisualStudio.TestTools.UnitTesting;
using L049_Linq_Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L049_Linq_Extensions.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Task1Test()
        {
            // Arrange
            List<int> fake = new List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 };
            List<int> expected = new List<int> { 78, 85, 39, 49, 55, 95 };

            // Act
            var actual = Program.Task1(fake);

            // Assert
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
            Assert.AreEqual(expected[4], actual[4]);
            Assert.AreEqual(expected[5], actual[5]);
        }

        [TestMethod()]
        public void Task2Test()
        {
            // Arrange
            List<string> fake = new List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", "Magenta", "Tomato", "Cyan" };
            List<string> expected = new List<string> { "GREEN", "PURPLE", "MAGENTA", "TOMATO" };

            // Act
            var actual = Program.Task2(fake);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task3Test()
        {
            // Arrange
            List<string> fake = new List<string> { "dangus", "afro", "vanduo", "darzelis", "darzove", "kremas", "valdiklis", "daumantas", "mokinys", "pazymys", "danguole" };
            List<string> expected = new List<string> { "dangus", "darzelis", "daumantas" };
            // Act
            var actual = Program.Task3(fake);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}