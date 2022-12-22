using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Helpers;
using L05_Tasks_MSSQL.Helpers.IHelpers;
using L05_Tasks_MSSQL.Repository;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace L05_Tasks_MSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IPasswordService, PasswordService>();
            builder.Services.AddScoped<IJwtService, JwtService>();

            builder.Services.AddTransient<IBookWrapper, BookWrapper>();
            builder.Services.AddTransient<ILibraryBookAdapter, LibraryBookAdapter>();
            builder.Services.AddTransient<IUserBookAdapter, UserBookAdapter>();
            builder.Services.AddTransient<IUserAdapter, UserAdapter>(); 

            builder.Services.AddTransient<IDebtHelper, DebtHelper>();
            builder.Services.AddTransient<ILibraryHelper, LibraryHelper>();
            builder.Services.AddTransient<IStatsHelper, StatsHelper>();
            builder.Services.AddTransient<IDeliveryService, DeliveryService>();
            builder.Services.AddTransient<IPointsService, PointsService>();
            builder.Services.AddTransient<IPaymentService, PaymentService>(); 

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<ILibraryBookRepository, LibraryBookRepository>();
            builder.Services.AddScoped<IUserBookRepository, UserBookRepository>();
            builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

            builder.Services.AddDbContext<BookStoreContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
                option.UseLazyLoadingProxies();
            });

            builder.Services.AddHttpClient("OpenRouteServiceApi", client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["ExternalServices3000:OpenRouteServiceApiUrl"]);
                client.Timeout = TimeSpan.FromSeconds(10);
                client.DefaultRequestHeaders.Clear();
            });

            builder.Services.AddHttpClient("HolidayApi", client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["ExternalServices3000:HolidayApiUrl"]);
                client.Timeout = TimeSpan.FromSeconds(10);
                client.DefaultRequestHeaders.Clear();
            });

            var key = builder.Configuration.GetValue<string>("MyApiSettings:SuperDuperSecret");
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath);

                // This is added to show JWT UI part in Swagger
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description =
                        "JWT Authorization header is using Bearer scheme. \r\n\r\n" +
                        "Enter 'Bearer' and token separated by a space. \r\n\r\n" +
                        "Example: \"Bearer d5f41g85d1f52a\"",
                    Name = "Authorization", // Header key name
                    In = ParameterLocation.Header,
                    Scheme = "Bearer",
                    BearerFormat = "JWT"
                });

                option.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();    // ORDER MATTERS ! ! !
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}