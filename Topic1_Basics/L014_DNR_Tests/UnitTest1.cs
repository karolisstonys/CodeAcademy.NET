namespace L014_DNR_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GrandinesNormalizavimas_Test()
        {
            var expected = "CAG-ACT";
            var actual = L014_DNR.Program.GrandinesNormalizavimas(" CaG-  ACt  ", out string msg);
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
            var actual = L014_DNR.Program.ArGrandineTikValidi("Tbb-TbC-GAC-TAC-CBB-CAG-ACT-TAA-CCA-GBC-CAT-AGA-GCT");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArGrandineNormalizuotaIrValidi_Test()
        {
            var expected = true;
            var actual = L014_DNR.Program.ArGrandineNormalizuotaIrValidi("TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PridejimasPrieGrandinesGalo_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.PridejimasPrieGrandinesGalo(ref dnr, "Tac");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PridejimasPrieGrandinesGalo_Test1()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.PridejimasPrieGrandinesGalo(ref dnr, "B24");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PridejimasPrieGrandinesGalo_Test2()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.PridejimasPrieGrandinesGalo(ref dnr, "TACTAC");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalinamasElementas_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.SalinamasElementas(ref dnr, "TAC");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalinamasElementas_Test1()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.SalinamasElementas(ref dnr, "1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalinamasElementas_Test2()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.SalinamasElementas(ref dnr, "AAA");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalinamasElementas_Test3()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.SalinamasElementas(ref dnr, "BBB");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalinamasElementas_Test4()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.SalinamasElementas(ref dnr, "15");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GrandinesValidacija_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.GrandinesValidacija(ref dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GrandinesValidacija_Test1()
        {
            string dnr = "TBB-TAC-123-456-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.GrandinesValidacija(ref dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeiciamasElementas_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.KeiciamasElementas(ref dnr, "1", "aaa", out string msg);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeiciamasElementas_Test1()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.KeiciamasElementas(ref dnr, "CGT", "tTt", out string msg);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeiciamasElementas_Test2()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.KeiciamasElementas(ref dnr, "1", "a1a", out string msg);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeiciamasElementas_Test3()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = false;
            var actual = L014_DNR.Program.KeiciamasElementas(ref dnr, "GGG", "AAA", out string msg);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeistiGCTiAGG_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.PakeistiGCTiAGG(ref dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeistiGCTiAGG_Test1()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-AAA";
            var expected = false;
            var actual = L014_DNR.Program.PakeistiGCTiAGG(ref dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraCAT_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = L014_DNR.Program.ArYraCAT(dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraCAT_Test1()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-TTT-AGA-AAA";
            var expected = false;
            var actual = L014_DNR.Program.ArYraCAT(dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JeiYraParodytiTreciaIrPenktaElementus_Test()
        {
            string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "Trecias grandines elementas: GAC. Penktas grandines elementas: CGT.";
            var actual = L014_DNR.Program.JeiYraParodytiTreciaIrPenktaElementus(dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JeiYraParodytiTreciaIrPenktaElementus_Test1()
        {
            string dnr = "TCG-TAC-GAC-TAC";
            var expected = "DNR grandines elementu yra per mazai";
            var actual = L014_DNR.Program.JeiYraParodytiTreciaIrPenktaElementus(dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraRaidziuGrandineje_Test()
        {
            string dnr = "TCG";
            var expected = "Raidziu kiekis DNR grandineje yra 3";
            var actual = L014_DNR.Program.KiekYraRaidziuGrandineje(dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraRaidziuGrandineje_Test1()
        {
            string dnr = "TCG-TAC";
            var expected = "Raidziu kiekis DNR grandineje yra 6";
            var actual = L014_DNR.Program.KiekYraRaidziuGrandineje(dnr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekKartuKartojasiIvestosRaides_Test()
        {
            string dnr = "TCG-TAC";
            var expected = 1;
            var actual = L014_DNR.Program.KiekKartuKartojasiIvestosRaides(dnr, "TAC");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekKartuKartojasiIvestosRaides_Test1()
        {
            string dnr = "TCG-TAC";
            var expected = 0;
            var actual = L014_DNR.Program.KiekKartuKartojasiIvestosRaides(dnr, "AAA");
            Assert.AreEqual(expected, actual);
        }



        





    }
}