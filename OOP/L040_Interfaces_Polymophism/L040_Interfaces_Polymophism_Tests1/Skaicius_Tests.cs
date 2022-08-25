using Microsoft.VisualStudio.TestTools.UnitTesting;
using L040_Interfaces_Polymophism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L040_Interfaces_Polymophism.Program_Tests
{
    [TestClass()]
    public class Skaicius_Tests
    {
        [TestMethod()]
        public void Prideti_Test()
        {
            var skaicius1 = new Skaicius();
            var actual = skaicius1.Prideti(8);
            var expected = 50;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Atimti_Test()
        {
            var skaicius1 = new Skaicius();
            var actual = skaicius1.Atimti(2);
            var expected = 40;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Padauginti_Test()
        {
            var skaicius1 = new Skaicius();
            var actual = skaicius1.Padauginti(3);
            var expected = 126;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void Padalinti_Test()
        {
            var skaicius1 = new Skaicius();
            var actual = skaicius1.Padalinti(2);
            var expected = 21;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void PakeltiKvadratu_Test()
        {
            var skaicius1 = new Skaicius();
            var actual = skaicius1.PakeltiKvadratu();
            var expected = 1764;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void PakeltiKubu_Test()
        {
            var skaicius1 = new Skaicius();
            var actual = skaicius1.PakeltiKubu();
            var expected = 74088;
            Assert.AreEqual(actual, expected);
        }
    }
}