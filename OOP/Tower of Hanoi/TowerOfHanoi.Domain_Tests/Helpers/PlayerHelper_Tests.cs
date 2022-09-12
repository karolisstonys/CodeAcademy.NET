using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerOfHanoi.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers_Tests
{
    [TestClass()]
    public class PlayerHelper_Tests
    {
        [TestMethod()]
        public void LookForHelpInCsv_Test()
        {
            //Arrange
            string fakeCsvSearchTerm = "2,2,3,1";
            string[] fakeAllCsvFileLines =
            {
                "2022-09-10 16:35:02,1,2,1,1,1",
                "2022-09-10 16:35:02,2,3,1,1,1",
                "2022-09-10 16:35:02,3,3,2,1,1",
                "2022-09-10 16:35:02,4,2,2,1,1",
                "2022-09-10 16:35:02,5,2,2,3,1",
                "2022-09-10 16:35:02,6,2,2,3,1",
                "2022-09-10 16:35:02,7,3,2,3,1",
                "2022-09-10 16:35:02,8,3,1,3,1",
                "2022-09-10 16:35:02,9,1,1,3,1",
                "2022-09-10 16:35:02,10,1,1,2,1"
            };
            GameStatisticList fakeAllStatistics = new GameStatisticList();
            fakeAllStatistics.AllGamesStatistics.Add( 
                new GameStatistic() { 
                    GameDateTime = new DateTime(2022, 09, 10, 16, 35, 02), 
                    MovesUntilVictory = "15", 
                    VictoryStatus = true 
                }
            );
            string expected = "paimkite diską iš antro stulpelio padėkite į trečią";

            //Act
            var actual = PlayerHelper.LookForHelpInCsv(fakeCsvSearchTerm, fakeAllCsvFileLines, fakeAllStatistics);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}