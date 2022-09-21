using L056_Db_Dapper_Tasks.Database;
using L056_Db_Dapper_Tasks.Database.Dapper;

namespace L056_Db_Dapper_Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1();

        }


        /* Uzduotis 1: Parašykite programą NoteBook, kuri naudotų Dapper. Jūsų programa turėtų turėti klasę Note, kuri savyje turėtų šiuos properties:
        Id [INT IDENTITY(1,1) PRIMARY KEY]
        Title [varchar]
        Description [varchar]
        CreationDatetime [datetime]
        Priority [varchar] */
        public static void Task1()
        {
            Console.WriteLine("Fetching connection string...");
            var dbConfig = new DatabaseConfig();

            Console.WriteLine("Staring us Database check...");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check is COMPLETE.");
        }
    }
}