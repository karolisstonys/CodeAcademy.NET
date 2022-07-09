namespace L014_DNR_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArPasirinkimasYraSkaicius_Test()
        {
            var expected = true;
            var actual = L014_DNR.Program.ArPasirinkimasYraSkaicius("1", 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArPasirinkimasYraSkaicius_Test1()
        {
            var expected = false;
            var actual = L014_DNR.Program.ArPasirinkimasYraSkaicius("a", 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArPasirinkimasYraSkaicius_Test2()
        {
            var expected = false;
            var actual = L014_DNR.Program.ArPasirinkimasYraSkaicius("5", 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GrandinesNormalizavimas_Test()
        {
            var expected = "CAG-ACT";
            var actual = L014_DNR.Program.GrandinesNormalizavimas("CAG-ACT");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArGrandineTikValidi_Test()
        {
            var expected = true;
            var actual = L014_DNR.Program.ArGrandineTikValidi("TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArGrandineTikValidi_Test1()
        {
            var expected = false;
            var actual = L014_DNR.Program.ArGrandineTikValidi("TCG-TbC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GBC-CAT-AGA-GCT");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArGrandineNormalizuotaIrValidi_Test()
        {
            var expected = true;
            var actual = L014_DNR.Program.ArGrandineNormalizuotaIrValidi("TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT");
            Assert.AreEqual(expected, actual);
        }













    }
}