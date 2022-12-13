using Microsoft.VisualStudio.TestTools.UnitTesting;
using L05_Tasks_MSSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.UserDto;

namespace L05_Tasks_MSSQL.Helpers_Tests
{
    [TestClass()]
    public class LibraryHelper_Tests
    {
        [TestMethod()]
        public void CanThisBookBeTaken_True_Test()
        {
            var libraryBook = new LibraryBook()
            {
                Id = 1,
                BookISBN = "1234501",
                Book = new Book(),
                IsTaken = false,
                UserBooks = null,
                Created = new DateTime(2022, 12, 10),
                Updated = new DateTime(2022, 12, 13)
            };

            var expectedAnswer = true;
            var expectedMessage = "Book can be taken";

            var sut = new LibraryHelper();
            var actual = sut.CanThisBookBeTaken(libraryBook);

            Assert.AreEqual(expectedAnswer, actual.Answer);
            Assert.AreEqual(expectedMessage, actual.Message);
        }


        [TestMethod]
        public void CanThisBookBeTaken_False_Test()
        {
            var libraryBook = new LibraryBook()
            {
                Id = 2,
                BookISBN = "1234502",
                Book = new Book(),
                IsTaken = true,
                UserBooks = null,
                Created = new DateTime(2022, 12, 11),
                Updated = new DateTime(2022, 12, 15)
            };

            var expectedAnswer = false;
            var expectedMessage = "Book is already taken";

            var sut = new LibraryHelper();
            var actual = sut.CanThisBookBeTaken(libraryBook);

            Assert.AreEqual(expectedAnswer, actual.Answer);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        [TestMethod()]
        public void CanThisUserTakeABook_TakenLibraryBooks_Test()
        {
            var user = new GetUserDto()
            {
                UserId = 1,
                FullName = "Perrtras Petriukas",
                Role = "Client",
                TakenLibraryBooks = 5,
                BooksNotReturnedInTime = 1,
                TotalDebt = 9.9
            };

            var expectedAnswer = false;
            var expectedMessage = "User has too many books taken already";

            var sut = new LibraryHelper();
            var actual = sut.CanThisUserTakeABook(user);

            Assert.AreEqual(expectedAnswer, actual.Answer);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        [TestMethod()]
        public void CanThisUserTakeABook_BooksNotReturnedInTime_Test()
        {
            var user = new GetUserDto()
            {
                UserId = 2,
                FullName = "Perrtras Petriukas",
                Role = "Client",
                TakenLibraryBooks = 4,
                BooksNotReturnedInTime = 2,
                TotalDebt = 9.9
            };

            var expectedAnswer = false;
            var expectedMessage = "User has too many books not returned in time";

            var sut = new LibraryHelper();
            var actual = sut.CanThisUserTakeABook(user);

            Assert.AreEqual(expectedAnswer, actual.Answer);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        [TestMethod()]
        public void CanThisUserTakeABook_TotalDebt_Test()
        {
            var user = new GetUserDto()
            {
                UserId = 3,
                FullName = "Perrtras Petriukas",
                Role = "Client",
                TakenLibraryBooks = 3,
                BooksNotReturnedInTime = 1,
                TotalDebt = 10.1
            };

            var expectedAnswer = false;
            var expectedMessage = "User has too much debt";

            var sut = new LibraryHelper();
            var actual = sut.CanThisUserTakeABook(user);

            Assert.AreEqual(expectedAnswer, actual.Answer);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        [TestMethod()]
        public void CanThisUserTakeABook_Pass_Test()
        {
            var user = new GetUserDto()
            {
                UserId = 3,
                FullName = "Perrtras Petriukas",
                Role = "Client",
                TakenLibraryBooks = 3,
                BooksNotReturnedInTime = 1,
                TotalDebt = 8.12
            };

            var expectedAnswer = true;
            var expectedMessage = "This user can take a book";

            var sut = new LibraryHelper();
            var actual = sut.CanThisUserTakeABook(user);

            Assert.AreEqual(expectedAnswer, actual.Answer);
            Assert.AreEqual(expectedMessage, actual.Message);
        }
    }
}