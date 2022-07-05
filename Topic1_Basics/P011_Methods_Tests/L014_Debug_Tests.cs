using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L011_Methods_Tests
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

        [TestMethod]
        public void PoligonoVidiniuKampuSuma_Test()
        {
            int fakeKrastiniuKiekis = 12;
            double expected = 1800;
            var actual = L014_debug.Program.PoligonoVidiniuKampuSuma(fakeKrastiniuKiekis);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DaugiakampioSkaiciavimas_Test()
        {
            int fakeKrastiniuKiekis = 8;
            int fakeKrastinesIlgis = 150;
            int fakeR = 5;
            double expected = 3000;
            var actual = L014_debug.Program.DaugiakampioSkaiciavimas(fakeKrastiniuKiekis, fakeKrastinesIlgis, fakeR);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeturkampioSkaiciavimas_Test()
        {
            int fakeKrastinesIlgis = 200;
            double expected = 40000;
            var actual = L014_debug.Program.KeturkampioSkaiciavimas(fakeKrastinesIlgis);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrikampioSkaiciavimas_Test()
        {
            int fakeKrastinesIlgis = 23;
            int fakeH = 47;
            double expected = 540.5;
            var actual = L014_debug.Program.TrikampioSkaiciavimas(fakeKrastinesIlgis, fakeH);
            Assert.AreEqual(expected, actual);
        }
    }
}
