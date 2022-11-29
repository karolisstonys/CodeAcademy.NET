using Wishlist.Services;
using Wishlist.Services.Interfaces;
using Wishlist.Data;
using Microsoft.EntityFrameworkCore;

namespace Wishlist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IGuidService, GuidService>();
            builder.Services.AddTransient<IPasswordService, PasswordService>();

            builder.Services.AddDbContext<WishlistContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("WishlistSQLConnection"));
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}