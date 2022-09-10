using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerOfHanoi.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Enums;

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
            bool logToHTML = true;
            bool logToTXT = true;
            var tower = new Tower(logToCSV, logToHTML, logToTXT);



            //Act

            //Assert
            Assert.Fail();
        }

        /*
        public static string CreateStringForCsv(string[] logData)
        {         
            return logData[0] + "," + logData[1] + "," + logData[2] + "," + logData[3] + "," + logData[4] + "," + logData[5];
        }
        */
    }
}