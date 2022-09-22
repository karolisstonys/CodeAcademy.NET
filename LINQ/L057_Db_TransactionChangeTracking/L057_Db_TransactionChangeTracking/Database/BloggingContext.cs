﻿using Microsoft.EntityFrameworkCore;
using L057_Db_TransactionChangeTracking.Database.Models;

namespace L057_Db_TransactionChangeTracking.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions options) : base(options)
        {
        }

        public BloggingContext()
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) //reikalinga testams
            {
                optionsBuilder.UseSqlite(@"Data Source=Blogging.db");
                optionsBuilder.UseLazyLoadingProxies(); /* Užtikriname kad EF palaikytu lazy loading instaliuojam package Microsoft.EntityFrameworkCore.Proxies */
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AuthorBlog>().HasKey(sc => new { sc.AuthorId, sc.BlogId });

            modelBuilder.Entity<AuthorBlog>()
                .HasOne(sc => sc.Author)
                .WithMany(s => s.AuthorBlog)
                .HasForeignKey(sc => sc.AuthorId);


            modelBuilder.Entity<AuthorBlog>()
                .HasOne(sc => sc.Blog)
                .WithMany(s => s.AuthorBlog)
                .HasForeignKey(sc => sc.BlogId);
        }
    }
}
