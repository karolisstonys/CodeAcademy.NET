using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Repository;
using L04_EF_Applying_To_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

namespace L04_EF_Applying_To_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IDishRepository, DishRepository>();
            builder.Services.AddDbContext<RestaurantContext>(option =>
            {
                option.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
                option.UseLazyLoadingProxies();     // lazyLoading // su 'virtual' navigacinius propercius istraukia is karto
            });

            builder.Services.AddControllers()
                .AddJsonOptions(option => option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
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