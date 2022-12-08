using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace L05_Tasks_MSSQL.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .Property(u => u.ECoverType)
            .HasConversion<string>()
            .HasMaxLength(50);

            modelBuilder.Entity<Book>()
                .HasData(
                new Book(1, "In Search of Lost Time", "Marcel Proust", ECoverType.Paperback, 2001, DateTime.Now, DateTime.Now),
                new Book(2, "Ulysses", "James Joyce", ECoverType.Hardcover, 2002, DateTime.Now, DateTime.Now),
                new Book(3, "Don Quixote", "Miguel de Cervantes", ECoverType.Electronic, 2003, DateTime.Now, DateTime.Now),
                new Book(4, "One Hundred Years of Solitude", "Gabriel Garcia Marquez", ECoverType.Hardcover, 2004, DateTime.Now, DateTime.Now),
                new Book(5, "The Great Gatsby", "F. Scott Fitzgerald", ECoverType.Hardcover, 2005, DateTime.Now, DateTime.Now),
                new Book(6, "Moby Dick", "Herman Melville", ECoverType.Paperback, 2006, DateTime.Now, DateTime.Now),
                new Book(7, "War and Peace", "Leo Tolstoy", ECoverType.Paperback, 2007, DateTime.Now, DateTime.Now),
                new Book(8, "Hamlet", "William Shakespeare", ECoverType.Hardcover, 2008, DateTime.Now, DateTime.Now),
                new Book(9, "King Lear", "William Shakespeare", ECoverType.Hardcover, 2009, DateTime.Now, DateTime.Now),
                new Book(10, "The Tempest", "William Shakespeare", ECoverType.Paperback, 2010, DateTime.Now, DateTime.Now)
                );
        }
    }
}
