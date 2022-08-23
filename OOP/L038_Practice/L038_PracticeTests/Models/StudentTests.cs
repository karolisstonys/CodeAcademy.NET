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
    public class StudentTests
    {
        [TestMethod()]
        public void SetUpto3Courses_Test()
        {
            FakeRandom overridenRandomClass = new FakeRandom();
            var student = new Student(overridenRandomClass);
            student.SetUpto3Courses();
            //int rnd = universityPerson1.NumberOfHobbies;

            var fake0 = "Movies watching";
            var expected0 = student.Hobbies[0].Text;
            var fake1 = "Board games";
            var expected1 = student.Hobbies[1].Text;

            Assert.AreEqual(2, student.Hobbies.Count);
            Assert.AreEqual(fake0, expected0);
            Assert.AreEqual(fake1, expected1);
        }
    }
}