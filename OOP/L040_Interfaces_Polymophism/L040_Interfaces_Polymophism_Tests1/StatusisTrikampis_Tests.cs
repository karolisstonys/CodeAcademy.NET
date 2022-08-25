using Microsoft.VisualStudio.TestTools.UnitTesting;
using L040_Interfaces_Polymophism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L040_Interfaces_Polymophism_Tests
{
    [TestClass()]
    public class StatusisTrikampis_Tests
    {
        [TestMethod()]
        public void Plotas_Test()
        {
            var statusisTrikampis1 = new StatusisTrikampis(10, 8);
            var actual = statusisTrikampis1.Plotas();
            var expected = 40;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Perimetras_Test()
        {
            var statusisTrikampis1 = new StatusisTrikampis(10, 8);
            var actual = statusisTrikampis1.Perimetras();
            double expected = 30.81;
            Assert.AreEqual(expected, actual);
        }
    }
}