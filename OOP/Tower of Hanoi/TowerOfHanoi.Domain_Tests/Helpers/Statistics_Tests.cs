using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerOfHanoi.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Helpers_Tests
{
    [TestClass()]
    public class Statistics_Tests
    {
        [TestMethod()]
        public void GetAllUniqueDateTimesFromTxtFileLines_Test()
        {
            //Arrange
            string[] fakeStringArray = {"žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 1, 1 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą",
                                        "žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 2, 2 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į trečią",
                                        "žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 3, 1 dalių diskas buvo paimtas iš antro sulpelio ir padėtas į trečią",
                                        "žaidime kuris pradėtas 2022-09-11 13:28:03, ėjimu nr 1, 1 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą",
                                        "žaidime kuris pradėtas 2022-09-11 13:28:03, ėjimu nr 2, 1 dalių diskas buvo paimtas iš antro sulpelio ir padėtas į trečią",
                                        "žaidime kuris pradėtas 2022-09-11 13:28:03, ėjimu nr 3, 2 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą",
                                        "žaidime kuris pradėtas 2022-09-11 17:10:24, ėjimu nr 1, 1 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą",
                                        "žaidime kuris pradėtas 2022-09-11 17:10:24, ėjimu nr 2, 1 dalių diskas buvo paimtas iš antro sulpelio ir padėtas į trečią",
                                        "žaidime kuris pradėtas 2022-09-11 17:10:24, ėjimu nr 3, 2 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į pirmą" };

            var expected = new List<DateTime>()
            {
                new DateTime(2022, 09, 11, 12, 13, 28),
                new DateTime(2022, 09, 11, 13, 28, 03),
                new DateTime(2022, 09, 11, 17, 10, 24),
            };

            //Act
            var actual = Statistics.GetAllUniqueDateTimesFromTxtFileLines(fakeStringArray);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAllUniqueDateTimesFromHtmlFileLines_Test()
        {
            //Arrange
            List<string> fakeList = new List<string>();
            fakeList.Add("<table border>");
            fakeList.Add("<tr>");
            fakeList.Add("<th>ŽAIDIMO PRADŽIOS DATA</th>");
            fakeList.Add("<th>ĖJIMO NR</td>");
            fakeList.Add("<th>DISKO 1 VIETA</th>");
            fakeList.Add("<th>DISKO 2 VIETA</th>");
            fakeList.Add("<th>DISKO 3 VIETA</th>");
            fakeList.Add("<th>DISKO 4 VIETA</th>");
            fakeList.Add("</tr><tr>");
            fakeList.Add("<td>2022-09-12 12:57:15</td>");
            fakeList.Add("<td>1</td>");
            fakeList.Add("<td>2</td>");
            fakeList.Add("<td>1</td>");
            fakeList.Add("<td>1</td>");
            fakeList.Add("<td>1</td>");
            fakeList.Add("</tr>");
            fakeList.Add("<tr>");
            fakeList.Add("<td>2022-09-12 12:57:15</td>");
            fakeList.Add("<td>2</td>");
            fakeList.Add("<td>2</td>");
            fakeList.Add("<td>3</td>");
            fakeList.Add("<td>1</td>");
            fakeList.Add("<td>1</td>");
            fakeList.Add("</tr>");
            fakeList.Add("</table>");

            var expected = new List<DateTime>()
            {
                new DateTime(2022, 09, 12, 12, 57, 15)
            };

            //Act
            var actual = Statistics.GetAllUniqueDateTimesFromHtmlFileLines(fakeList);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAllUniqueDateTimesFromCsvFileLines_Test()
        {
            //Arrange
            string[] fakeStringArray = {"2022-09-10 13:10:29,1,2,1,1,1",
                                        "2022-09-10 13:10:29,2,2,3,1,1",
                                        "2022-09-10 13:10:29,3,3,3,1,1",
                                        "2022-09-11 12:13:28,1,2,1,1,1",
                                        "2022-09-11 12:13:28,2,2,3,1,1",
                                        "2022-09-11 12:13:28,3,3,3,1,1",
                                        "2022-09-12 01:59:54,1,2,1,1,1",
                                        "2022-09-12 01:59:54,2,2,3,1,1",
                                        "2022-09-12 01:59:54,3,3,3,1,1" };

            var expected = new List<DateTime>()
            {
                new DateTime(2022, 09, 10, 13, 10, 29),
                new DateTime(2022, 09, 11, 12, 13, 28),
                new DateTime(2022, 09, 12, 01, 59, 54),
            };

            //Act
            var actual = Statistics.GetAllUniqueDateTimesFromCsvFileLines(fakeStringArray);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}