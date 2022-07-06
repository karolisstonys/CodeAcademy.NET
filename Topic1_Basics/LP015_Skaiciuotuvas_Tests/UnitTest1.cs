using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP015_Skaiciuotuvas_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Skaiciuotuvas_Test0()
        {
            var expected = 10 * 10;
            var actual = LP015_Skaiciuotuvas.Program.Skaiciuotuvas("10", "10", "^2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test1()
        {
            var expected = 10.1 * 10.1;
            var actual = LP015_Skaiciuotuvas.Program.Skaiciuotuvas("10,1", "10", "^2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test2()
        {
            var expected = 10.1 - 10;
            var actual = LP015_Skaiciuotuvas.Program.Skaiciuotuvas("10,1", "10", "2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test3()
        {
            var expected = 10.1 * 10.1;
            var actual = LP015_Skaiciuotuvas.Program.Skaiciuotuvas("10,1", "10", "5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test4()
        {
            var expected = 10.1 + 10;
            var actual = LP015_Skaiciuotuvas.Program.Skaiciuotuvas("10,1", "10", "+");

            Assert.AreEqual(expected, actual);
        }
    }
}