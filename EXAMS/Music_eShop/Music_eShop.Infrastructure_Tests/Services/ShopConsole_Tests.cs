using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music_eShop.Domain.Services;
using Music_eShop.Infrastructure;
using Music_eShop.Infrastructure.Database;
using Music_eShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Domain.Services_Tests
{
    [TestClass()]
    public class ShopConsole_Tests
    {
        [TestMethod()]
        public void Login_Test()
        {
            //Arrange
            ShopConsole shopConsole = new ShopConsole();

            //Act
            var user = shopConsole.Login("60");

            //Assert
            Assert.IsTrue(user.Name == "Karolis Stonys");
        }
    }
}