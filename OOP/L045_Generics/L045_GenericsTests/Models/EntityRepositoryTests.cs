using Microsoft.VisualStudio.TestTools.UnitTesting;
using L045_Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L045_Generics.Interfaces;

namespace L045_Generics.Models.Tests
{
    [TestClass()]
    public class EntityRepositoryTests
    {
        [TestMethod()]
        public void Add_AddingNewUser_ReturnsDifferentCount()
        {
            //Arrange
            int expected = 2;
            EntityRepository<IUser> repo = new EntityRepository<IUser>();
            IUser fakePrivateClient = new PrivateClient();
            IUser fakeBusinessClient = new BusinessClient();

            //Act
            repo.Add(fakePrivateClient);
            repo.Add(fakeBusinessClient);
            int actual = repo.Fetch().Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}