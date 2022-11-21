using L03_Tasks.Models;

namespace L03_Tasks.Data
{
    public class BookSet : IBookSet
    {
        private List<Book> books = new List<Book>()
        {
            new Book(1, "In Search of Lost Time", "Marcel Proust", ECoverType.Paperback, 2001),
            new Book(2, "Ulysses", "James Joyce", ECoverType.Hardcover, 2002),
            new Book(3, "Don Quixote", "Miguel de Cervantes", ECoverType.Electronic, 2003),
            new Book(4, "One Hundred Years of Solitude", "Gabriel Garcia Marquez", ECoverType.Hardcover, 2004),
            new Book(5, "The Great Gatsby", "F. Scott Fitzgerald", ECoverType.Hardcover, 2005),
            new Book(6, "Moby Dick", "Herman Melville", ECoverType.Paperback, 2006),
            new Book(7, "War and Peace", "Leo Tolstoy", ECoverType.Paperback, 2007),
            new Book(8, "Hamlet", "William Shakespeare", ECoverType.Hardcover, 2008),
            new Book(9, "King Lear", "William Shakespeare", ECoverType.Hardcover, 2009),
            new Book(10, "The Tempest", "William Shakespeare", ECoverType.Paperback, 2010)
        };

        public List<Book> Books 
        { 
            get { return books; } 
            set { books = value; } 
        }
    }
}
