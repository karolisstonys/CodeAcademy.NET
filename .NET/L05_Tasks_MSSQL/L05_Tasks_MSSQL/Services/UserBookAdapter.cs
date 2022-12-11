using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Services.IServices;

namespace L05_Tasks_MSSQL.Services
{
    public class UserBookAdapter : IUserBookAdapter
    {
        public UserBook Adapt(User user, LibraryBook libraryBook)
        {
            return new UserBook()
            {
                Id = libraryBook.Id,
                UserId = user.Id,
                User = user,
                LibraryBookId = libraryBook.Id,
                LibraryBook = libraryBook,
                BookTaken = DateTime.Now,
                BookReturned = null,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
        }

        public GetUserBookDto Adapt(UserBook userBook)
        {
            return new GetUserBookDto()
            {
                UserId = userBook.UserId,
                UserFullName = userBook.User.FullName,
                LibraryBookId = userBook.LibraryBookId,
                BookISBN = userBook.LibraryBook.Book.ISBN,
                BookTitle = userBook.LibraryBook.Book.Title,
                BookAuthor = userBook.LibraryBook.Book.Author,
                BookTaken = userBook.BookTaken,
                BookReturned = userBook.BookReturned
            };
        }

    }
}
