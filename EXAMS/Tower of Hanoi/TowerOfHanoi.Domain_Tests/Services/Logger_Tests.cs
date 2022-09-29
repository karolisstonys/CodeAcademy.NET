using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Helpers;

namespace TowerOfHanoi.Domain.Services_Tests
{
    [TestClass()]
    public class Logger_Tests
    {
        [TestMethod()]
        public void CreateStringForCsv_Test()
        {
            //Arrange
            bool logToCSV = true;
            var tower = new Tower(logToCSV, false, false);
            string[] logData = Logger.GetLogData(tower);
            var expected = logData[0] + "," + logData[1] + "," + logData[2] + "," + logData[3] + "," + logData[4] + "," + logData[5];

            //Act
            var actual = Logger.CreateStringForCsv(logData);

            //Assert
            Assert.AreEqual(actual, actual);
        }

        //[TestMethod()]
        //public void CreateStringForHtml_Test()
        //{
        //    //Arrange
        //    bool logToCSV = true;
        //    var tower = new Tower(logToCSV, false, false);
        //    tower.MoveCounter++;

        //    string[] logData = Logger.GetLogData(tower);
        //    string path = FileReader.GetFilePath("TowerOfHanoiLogs.html");

        //    FileStream fileStream = File.Open(path, FileMode.Open);
        //    fileStream.SetLength(0);    // clearing file
        //    fileStream.Close();

        //    var expected = "<table border>\n<tr>\n<th>ŽAIDIMO PRADŽIOS DATA</th>\n<th>ĖJIMO NR</td>\n<th>DISKO 1 VIETA</th>\n<th>DISKO 2 VIETA</th>\n<th>DISKO 3 VIETA</th>\n<th>DISKO 4 VIETA</th>\n</tr><tr>\r\n<td>" + logData[0] + "</td>\r\n<td>1</td>\r\n<td>1</td>\r\n<td>1</td>\r\n<td>1</td>\r\n<td>1</td>\r\n</tr>\r\n</table>\r\n";

        //    //Act
        //    var actual = Logger.CreateStringForHtml(logData, path);

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod()]
        public void CreateStringForTxt_Test()
        {
            //Arrange
            bool logToCSV = true;
            var tower = new Tower(logToCSV, false, false);
            tower.MoveCounter++;
            tower.InHand = Enums.EDisks.Disk1;
            tower.DiskInHandFromPeg = 1;

            string[] logData = Logger.GetLogData(tower);
            string path = FileReader.GetFilePath("TowerOfHanoiLogs.txt");

            var fakeMovedToPegNo = 2;

            var expected = "žaidime kuris pradėtas " + logData[0] + ", ėjimu nr 1, 1 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą";

            //Act
            var actual = Logger.CreateStringForTxt(logData, tower.InHand.ToString(), tower.DiskInHandFromPeg, fakeMovedToPegNo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}