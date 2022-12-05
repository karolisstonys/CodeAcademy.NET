using L07_Api_Car.Data;
using L07_Api_Car.Models;
using L07_Api_Car.Repository;
using L07_Api_Car.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace L07_Api_Car
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<ICarAdapter, CarAdapter>();
            builder.Services.AddTransient<IRepository<Car>, CarRepository>();
            builder.Services.AddDbContext<CarContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
                options =>
                {
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    options.IncludeXmlComments(xmlPath);
                });

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