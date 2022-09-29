namespace DB_Music_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Scaffold-DbContext "DataSource=I:\CODING\GitHub_CodeAcademy.NET\LINQ\DB_Music_Shop\DB_Music_Shop\InitialData\chinook.db" Microsoft.EntityFrameworkCore.Sqlite


            var a = GetCustomersByCountry("USA");


        }
    }
}