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
    public class Apskritimas_Tests
    {
        [TestMethod()]
        public void Plotas_Test()
        {
            var apskritimas = new Apskritimas(5);
            var actual = apskritimas.Plotas();
            var expected = 78.54;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Perimetras_Test()
        {
            var apskritimas = new Apskritimas(5);
            var actual = apskritimas.Perimetras();
            var expected = 31.41;
            Assert.AreEqual(expected, actual);
        }
    }
}