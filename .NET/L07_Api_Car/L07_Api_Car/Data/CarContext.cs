using L07_Api_Car.Data.InitialData;
using L07_Api_Car.Models;
using L07_Api_Car.Models.Enums;
using Microsoft.EntityFrameworkCore;
using static L07_Api_Car.Data.InitialData.CarInitialData;

namespace L07_Api_Car.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(c => c.Id);
            modelBuilder.Entity<Car>().Property(c => c.Make)
                                      .IsRequired()
                                      .HasMaxLength(30);
            modelBuilder.Entity<Car>().Property(c => c.Model)
                                      .IsRequired()
                                      .HasMaxLength(30);
            modelBuilder.Entity<Car>().Property(c => c.Year)
                                      .IsRequired();
            modelBuilder.Entity<Car>().Property(c => c.PlateNumber)
                                      .HasMaxLength(15);
            modelBuilder.Entity<Car>().Property(u => u.GearBox)
                                      .HasConversion<string>()
                                      .HasMaxLength(12);
            modelBuilder.Entity<Car>().Property(u => u.Fuel)
                                      .HasConversion<string>()
                                      .HasMaxLength(12);

            modelBuilder.Entity<Car>().HasData(CarData.DataSeed);
        }
    }
}
