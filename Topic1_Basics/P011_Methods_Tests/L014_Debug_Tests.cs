using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Methods_Tests
{
    [TestClass]
    public class L014_Debug_Tests
    {
        [TestMethod]
        public void Skaiciuotuvas_Test()
        {
            int fakeSkaicius1 = 10;
            int fakeSkaicius2 = 5;
            string fakeVeiksmas = "+";
            double expected = 15;
            var actual = L014_debug.Program.Skaiciuotuvas(fakeSkaicius1, fakeSkaicius2, fakeVeiksmas);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test1()
        {
            int fakeSkaicius1 = 10;
            int fakeSkaicius2 = 5;
            string fakeVeiksmas = "-";
            double expected = 5;
            var actual = L014_debug.Program.Skaiciuotuvas(fakeSkaicius1, fakeSkaicius2, fakeVeiksmas);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test2()
        {
            int fakeSkaicius1 = 10;
            int fakeSkaicius2 = 5;
            string fakeVeiksmas = "*";
            double expected = 50;
            var actual = L014_debug.Program.Skaiciuotuvas(fakeSkaicius1, fakeSkaicius2, fakeVeiksmas);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Skaiciuotuvas_Test3()
        {
            int fakeSkaicius1 = 10;
            int fakeSkaicius2 = 5;
            string fakeVeiksmas = "/";
            double expected = 2;
            var actual = L014_debug.Program.Skaiciuotuvas(fakeSkaicius1, fakeSkaicius2, fakeVeiksmas);
            Assert.AreEqual(expected, actual);
        }
    }
}
