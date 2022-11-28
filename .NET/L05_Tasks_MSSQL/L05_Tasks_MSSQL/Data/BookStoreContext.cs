using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace L05_Tasks_MSSQL.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasKey(b => new { b.Id, b.AuthorId });



        }
    }
}
