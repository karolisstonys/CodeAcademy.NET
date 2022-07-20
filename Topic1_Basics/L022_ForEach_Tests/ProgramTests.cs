using Microsoft.VisualStudio.TestTools.UnitTesting;
using L022_ForEach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L022_ForEach.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Task1Average_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7, 9 };
            double expected = 6;
            double actual = L022_ForEach.Program.Task1Average(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task2CheckIfPositive_Test()
        {
            var fake = new List<int> { -5, 0, -6, -8, 7, 9 };
            List<string> expected = new List<string> { "neigiamas", "teigiamas", "neigiamas", "neigiamas", "teigiamas", "teigiamas" };
            List<string> actual = L022_ForEach.Program.Task2CheckIfPositive(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task3Tax_Test()
        {
            var fake = new List<double> { 500, 112, 660, 880, 770, 5, 910 };
            double expected = 575.55;
            double actual = L022_ForEach.Program.Task3Tax(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task4ExtractNumbers_Test()
        {
            var fake = "1sd512sd5";
            var expected = "15125";
            var actual = L022_ForEach.Program.Task4ExtractNumbers(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Task4Ascending_Test()
        {
            var fake = "15125";
            var expected = "11255";
            var actual = L022_ForEach.Program.Task4Ascending(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}