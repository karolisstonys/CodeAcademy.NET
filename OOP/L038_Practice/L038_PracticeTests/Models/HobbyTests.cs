using Microsoft.VisualStudio.TestTools.UnitTesting;
using L038_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Models_Tests
{
    [TestClass()]
    public class HobbyTests
    {
        [TestMethod()]
        public void HobbyExtractor_Test()
        {
            var fake = "19,Computer games,Kompiuteriniai žaidimai";

            var hobby = new Hobby();
            hobby.HobbyExtractor(fake);

            var expected = new Hobby(19, "Computer games", "Kompiuteriniai žaidimai");

            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }
    }
}