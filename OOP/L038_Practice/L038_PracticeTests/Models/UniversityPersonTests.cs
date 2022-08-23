using Microsoft.VisualStudio.TestTools.UnitTesting;
using L038_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Models_Tests
{
    public class FakeRandom : Random
    {
        private int _iterator = -1;
        public override int Next(int minValue, int maxValue)
        {
            _iterator++;
            return _iterator switch
            {
                0 => 2,     // number of hobbies
                1 => 9,     // first hobby
                2 => 4,     // second hobby
                3 => 15,    // profession
                4 => 7,
                5 => 11,
                _ => throw new NotImplementedException()
            };
        }
    }




    [TestClass()]
    public class UniversityPersonTests
    {
        [TestMethod()]
        public void SetUpto4Hobies_Test()
        {
            FakeRandom overridenRandomClass = new FakeRandom();
            var universityPerson1 = new UniversityPerson(overridenRandomClass);
            universityPerson1.SetUpto4Hobies();
            //int rnd = universityPerson1.NumberOfHobbies;

            var fake0 = "Movies watching";
            var expected0 = universityPerson1.Hobbies[0].Text;
            var fake1 = "Board games";
            var expected1 = universityPerson1.Hobbies[1].Text;

            Assert.AreEqual(2, universityPerson1.Hobbies.Count);
            Assert.AreEqual(fake0, expected0);
            Assert.AreEqual(fake1, expected1);

        }


        [TestMethod()]
        public void SetProfession_Test()
        {
            FakeRandom overridenRandomClass = new FakeRandom();

            var universityPerson1 = new UniversityPerson(overridenRandomClass);
            universityPerson1.SetUpto4Hobies();
            universityPerson1.SetProfession(L038_Practice.InitialData.ProfessionInitialData.DataSeed);

            var fake1 = "Scientist";
            var expected1 = universityPerson1.Profession.Text;
            Assert.AreEqual(fake1, expected1);

            var universityPerson2 = new UniversityPerson(overridenRandomClass);
            //universityPerson2.SetUpto4Hobies();
            universityPerson2.SetProfession(L038_Practice.InitialData.ProfessionInitialData.DataSeedCsvComma, ",");
            var fake2 = "Engineer";
            var expected2 = universityPerson2.Profession.Text;
            Assert.AreEqual(fake2, expected2);

            var universityPerson3 = new UniversityPerson(overridenRandomClass);
            //universityPerson3.SetUpto4Hobies();
            universityPerson3.SetProfession(L038_Practice.InitialData.ProfessionInitialData.DataSeedCsvSemicolon, ";");
            var fake3 = "Lawyer";
            var expected3 = universityPerson3.Profession.Text;
            Assert.AreEqual(fake3, expected3);

        }

        [TestMethod()]
        public void GetCsv_Test()
        {
            FakeRandom overridenRandomClass = new FakeRandom();

            var universityPerson1 = new UniversityPerson(overridenRandomClass);
            universityPerson1.Id = 1;
            universityPerson1.FirstName = "Vardas";
            universityPerson1.LastName = "Pavarde";
            universityPerson1.Gender = EGender.MALE;
            universityPerson1.BirthDate = null;
            universityPerson1.Height = 90;
            universityPerson1.Weight = 190;
            universityPerson1.SetUpto4Hobies();
            universityPerson1.SetProfession(L038_Practice.InitialData.ProfessionInitialData.DataSeed);

            // "id,first,last,gender,birthdate,height,weight,profession,hobby1,hobby2,hobby3,hobby4"
            var expected = "1,Vardas,Pavarde,MALE,,90,190,16,10,5,,";
            var actual = universityPerson1.GetCsv();
            Assert.AreEqual(expected, actual);
        }
    }
}