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
    public class Kvadratas_Tests
    {
        [TestMethod()]
        public void Plotas_Test()
        {
            var kvadratas1 = new Kvadratas(10);
            var actual = kvadratas1.Plotas();
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Perimetras_Test()
        {
            var kvadratas1 = new Kvadratas(10);
            var actual = kvadratas1.Perimetras();
            var expected = 40;
            Assert.AreEqual(expected, actual);
        }
    }
}