using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure.Database;
using Music_eShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Infrastructure.Database_Tests
{
    [TestClass()]
    public class CustomerRepository_Tests
    {
        private ChinookContext _context;
        private ICustomerRepository _customers;

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<ChinookContext>()
                .UseInMemoryDatabase(databaseName: "Chinook")
                .Options;
            _context = new ChinookContext(options);
            _context.Customers.Add(new Customer() { CustomerId = 1001, FirstName = "Jonas", LastName = "Jonaitis", Email = "jonas@jonaitis.lt" });
            _context.Customers.Add(new Customer() { CustomerId = 1002, FirstName = "Egle", LastName = "Eglaite", Email = "egle@eglaite.lt" });
            _context.Customers.Add(new Customer() { CustomerId = 1003, FirstName = "Petras", LastName = "Petraitis", Email = "petras@petraitis.lt" });
            _context.Customers.Add(new Customer() { CustomerId = 1004, FirstName = "Monika", LastName = "Monikaite", Email = "monika@monikaite.lt" });
            _context.Employees.Add(new Employee() { EmployeeId = 1001, FirstName = "Darbuotojas", LastName = "Darbuotojauskas", Email = "darbuotojas@imone.lt" });
            _context.SaveChanges();
        }


        [TestMethod()]
        public void Customer_Get_Test()
        {
            //Arrange
            _customers = new CustomerRepository(_context);
            var expected = new Customer() { CustomerId = 1, FirstName = "Jonas", LastName = "Jonaitis", Email = "jonas@jonaitis.lt" };

            //Act
            var actual = _customers.Get("1001");

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
        }

        [TestMethod()]
        public void Customer_Add_Test()
        {
            //Arrange
            _customers = new CustomerRepository(_context);
            var firstName = "Rokas";
            var lastName = "Rokaitis";
            var email = "rokas@rokaitis.lt";

            //Act
            _customers.Add(firstName, lastName, email);

            //Assert
            Assert.IsTrue(_context.Customers.Any(c => c.FirstName == "Rokas"));
            Assert.IsTrue(_context.Customers.Any(c => c.LastName == "Rokaitis"));
            Assert.IsTrue(_context.Customers.Any(c => c.Email == "rokas@rokaitis.lt"));
        }

        [TestMethod()]
        public void Customer_Update_Test()
        {
            //Arrange
            _customers = new CustomerRepository(_context);
            var firstName = "Laura";
            var lastName = "Lauraite";
            var email = "laura@lauraite.lt";

            //Act
            _customers.Update(1002, firstName, lastName, null, null, null, null, null, null, null, null, email, 1001);
            
            //Assert
            Assert.IsFalse(_context.Customers.Any(c => c.FirstName == "Egle"));
            Assert.IsFalse(_context.Customers.Any(c => c.LastName == "Eglaite"));
            Assert.IsFalse(_context.Customers.Any(c => c.Email == "egle@eglaite.lt"));

            Assert.IsTrue(_context.Customers.Any(c => c.FirstName == "Laura"));
            Assert.IsTrue(_context.Customers.Any(c => c.LastName == "Lauraite"));
            Assert.IsTrue(_context.Customers.Any(c => c.Email == "laura@lauraite.lt"));
        }
    }
}