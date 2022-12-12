using Microsoft.VisualStudio.TestTools.UnitTesting;
using L07_Api_Car.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using L07_Api_Car.Repository;
using L07_Api_Car.Models;

namespace L07_Api_Car.Services_Tests
{
    [TestClass()]
    public class CarLeasingService_Tests
    {
        [AssemblyInitialize]
        public static void MyAssemblyInitialize(TestContext context) // pirmas dalykas kuris bus paleistas [AssemblyInitialize] // lifecycle hook
        {

        }

        [ClassInitialize]
        public static void MyClassInitialize(TestContext context) // antras dalykas kuris bus paleistas [ClassInitialize] // lifecycle hook
        {

        }

        [TestInitialize]
        public void MyTestInitialize() // trecias dalykas kuris bus paleistas [TestInitialize] // lifecycle hook
        {

        }

        #region Basic tests

        [TestMethod()]
        public void AddPrice_Test() // trecias dalykas kuris bus paleistas
        {
            var sut = new CarLeasingService(null);

            var actual = sut.AddPrive(100, 10);
            var expected = 110;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanLease_Test()
        {
            var sut = new CarLeasingService(null);
            Assert.ThrowsException<NotImplementedException>(() => sut.CanLease(1));
        }

        #endregion

        #region Data-driven tests

        [DataTestMethod()]
        [DataRow(100.0, 1.0, 101.0)]
        [DataRow(100.0, 10.0, 110.0)]
        [DataRow(0.0, 10.0, 0.0)]
        //[DataRow(0.0, 1.0, 1.0)] // cia klaidingas testas
        public void AddPrive_FromDataRow_Test(double price, double percent, double expected)
        {
            var sut = new CarLeasingService(null);

            decimal actual = sut.AddPrive(price, percent);


            Assert.AreEqual((decimal)expected, actual);
        }

        public static IEnumerable<object[]> CarLeasingService_TestData => new List<object[]>
        {
            new object[] { 100.0, 1.0, 101.0m },
            new object[] { 100.0, 10.0, 110.0m },
            new object[] { 0.0, 10.0, 0.0m },
            //new object[] { 0.0, 1.0, 1.0m } // cia klaidingas testas
        };

        [DataTestMethod()]
        [DynamicData(nameof(CarLeasingService_TestData), DynamicDataSourceType.Property)]
        public void AddPrive_FromDynamicData_Test(double price, double percent, decimal expected)
        {
            var sut = new CarLeasingService(null);
            decimal actual = sut.AddPrive(price, percent);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TestMethod()]
        public void ChangeYear_Test()
        {
            var repository_mock = new Mock<ICarRepository>(); // sukuriam imituojanti servisa!
            var fakeObj = new Car { Id = 1, Year =  new DateTime(1999, 9, 9) };
            //repository_mock.Setup(r => r.Get(1)).Returns(new Car { Id = 1 }); //konfiguruojame imituojanti servisa
            repository_mock.Setup(r => r.Get(It.IsAny<int>())).Returns(fakeObj); //konfiguruojame imituojanti servisa

            var sut = new CarLeasingService(repository_mock.Object);
            sut.ChangeYear(1, 2001);
            repository_mock.Verify(r => r.Update(fakeObj), Times.Once());

            var expected = new DateTime(2001, 1, 1);
            Assert.AreEqual(expected, fakeObj.Year);
        }
    }
}