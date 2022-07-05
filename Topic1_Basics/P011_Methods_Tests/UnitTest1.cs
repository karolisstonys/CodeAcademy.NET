namespace L011_Methods_Tests
{
    [TestClass]
    public class L011_Methods_Tests
    {        
        // 4
        [TestMethod]
        public void SkaiciuojamTarpus_Test1()
        {
            var fake = "ivedame betkoki teksti su tarpais";
            var expected = 4;
            var actual = L010_tasks.Program.SkaiciuojamTarpus(fake, 1);
            Assert.AreEqual(expected, actual);
        }

        // 5
        [TestMethod]
        public void SkaiciuojamTarpus_Test2()
        {
            var fake = "ivedame betkoki teksti su tarpais";
            var expected = 33;
            var actual = L010_tasks.Program.SkaiciuojamTarpus(fake, 2);
            Assert.AreEqual(expected, actual);
        }

        // 6
        [TestMethod]
        public void SkaiciuojamZodzius_Test1()
        {
            var fake = "siandiena as mokausi programuoti";
            var expected = 4;
            var actual = L010_tasks.Program.SkaiciuojamZodzius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SkaiciuojamZodzius_Test2()
        {
            var fake = "siandiena as mokausi programuoti       ";
            var expected = 4;
            var actual = L010_tasks.Program.SkaiciuojamZodzius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SkaiciuojamZodzius_Test3()
        {
            var fake = "              siandiena      as mokausi programuoti    ";
            var expected = 4;
            var actual = L010_tasks.Program.SkaiciuojamZodzius(fake);
            Assert.AreEqual(expected, actual);
        }

        // 7
        [TestMethod]
        public void SkaiciuojamGaloWhitespace_Test1()
        {
            var fake = "  aaaa bbbb cccc    ";
            var expected = 4;
            var actual = L010_tasks.Program.SkaiciuojamGaloWhitespace(fake);
            Assert.AreEqual(expected, actual);
        }

        // 8
        [TestMethod]
        public void SkaiciuojamPriekyjeWhitespace_Test1()
        {
            var fake = "  aaaa bbbb cccc    ";
            var expected = 2;
            var actual = L010_tasks.Program.SkaiciuojamPriekyjeWhitespace(fake);
            Assert.AreEqual(expected, actual);
        }       
        
        // 9
        [TestMethod]
        public void SkaiciuojamTarpusPriekyjeIrGale_Test1()
        {
            var fake = "  aaaa bbbb cccc    ";
            var expectedTarpaiPriekyje = 2;
            var expectedTarpaiGale = 4;
            var actualTarpaiPriekyje = L010_tasks.Program.SkaiciuojamTarpusPriekyjeIrGale(fake, out int actualTarpaiGale);
            Assert.AreEqual(expectedTarpaiPriekyje, actualTarpaiPriekyje);
            Assert.AreEqual(expectedTarpaiGale, actualTarpaiGale);
        }

        [TestMethod]
        public void SuskaiciuojamRaidesA_Test1()
        {
            var fake = "  aaaa bbbb cccc    ";
            var expected = 4;
            var actual = L010_tasks.Program.SuskaiciuojamRaidesA(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz1()
        {
            var fake = "as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz2()
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "Ne";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz3()
        {
            var fake = "mokausi programuoti labai    ";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz4()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz5()
        {
            var fake = "as mokausi!";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz6()
        {
            var fake = "as mokausi?";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz7()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_TestPvz8()
        {
            var fake = "as studijuojumokausi)";
            var expected = "Ne";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi_Test9()
        {
            var fake = "as studijuoju mokausi";
            var expected = "Taip";
            var actual = L010_tasks.Program.ArYraZodisMokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RaidesAVieta_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = 1;
            var actual = L010_tasks.Program.raidesAVieta(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}