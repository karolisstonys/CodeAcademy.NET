using Microsoft.EntityFrameworkCore;
using Wishlist.Models;

namespace Wishlist.Data
{
    public class WishlistContext : DbContext
    {
        public WishlistContext(DbContextOptions<WishlistContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .Property(u => u.Role)
            .HasConversion<string>()
            .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .HasData(
                new User
                (
                1,
                "admin",
                "/tNtEIXEn/zUpjgH+3nR/TZO4JYJvuFfNHj3K00+e70=:2ilTtW8WL+YGFIvOa1+/tg==",
                "b6775820-0f92-4b24-84f1-8bbd4617182d",
                Models.Enums.ERole.Admin)
                );  
        }
    }
}
