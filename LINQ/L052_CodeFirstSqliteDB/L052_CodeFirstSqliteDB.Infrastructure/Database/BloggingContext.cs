using L052_CodeFirstSqliteDB.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L052_CodeFirstSqliteDB.Infrastructure.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            // Daugiau apie SpecialFolders - https://en.wikipedia.org/wiki/Special_folder
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "CodeFirstBlogging.db");
        }

        // Registruojame nauja lentele savo duombazeje
        public DbSet<Person> Persons { get; set; }
        public string DbPath { get; } // ConnectionString

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");

            optionsBuilder.UseLazyLoadingProxies();



        }


    }
}
