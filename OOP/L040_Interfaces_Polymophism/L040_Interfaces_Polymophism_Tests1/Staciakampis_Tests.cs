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
    public class Staciakampis_Tests
    {

        [TestMethod()]
        public void Plotas_Test()
        {
            var staciakampis1 = new Staciakampis(10, 8);
            var actual = staciakampis1.Plotas();
            var expected = 80;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Perimetras_Test()
        {
            var staciakampis1 = new Staciakampis(10, 8);
            var actual = staciakampis1.Perimetras();
            var expected = 36;
            Assert.AreEqual(expected, actual);
        }
    }
}