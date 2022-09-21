using L056_Db_Dapper.Database;
using L056_Db_Dapper.Database.Dapper;

namespace L056_Db_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dapper!");

            Console.WriteLine("Fetching connection string...");
            var dbConfig = new DatabaseConfig();

            Console.WriteLine("Staring us Database check...");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check is COMPLETE.");

        }
    }
}