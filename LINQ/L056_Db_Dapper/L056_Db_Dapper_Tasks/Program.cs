using L056_Db_Dapper_Tasks.Database;
using L056_Db_Dapper_Tasks.Database.Dapper;
using L056_Db_Dapper_Tasks.Services;

namespace L056_Db_Dapper_Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1();

        }


        /* Uzduotis 1: Parašykite programą Notebook, kuri naudotų Dapper. Jūsų programa turėtų turėti klasę Note, kuri savyje turėtų šiuos properties:
        Id [INT IDENTITY(1,1) PRIMARY KEY]
        Title [varchar]
        Description [varchar]
        CreationDatetime [datetime]
        Priority [varchar] */


        /* Uzduotis 1.2: Parašykite programą Notebook, kuri naudotų Dapper. Jūsų programa turėtų turėti klasę Note ir lentele, kuri savyje turėtų šiuos properties:
        Id [INT IDENTITY(1,1) PRIMARY KEY]
        Title [varchar]
        Description [varchar]
        CreationDatetime [datetime default current_timestamp
        ]
        Priority [varchar]
        ---------------
        Užtikrinkite, kad jūsų programa teisingai veikia sukurdami NotebookWritter service klasę, kuri galėtų pridėti įrašus, 
        ištrinti įrašus ir juos atspausdinti. Grafinėje sąsajoje vartotojas turėtų turėti galimybę tęsti veiksmus programoje tol kol pasirinks Quit funkciją. */


        /* Uzduotis 1.3 Pridėkite galimybę atnaujinti įrašus. Naudokite Dapper Execute() metodą. SQL UPDATE sintaksė:
        UPDATE LentelėsPavadinimas
        SET Stulpelis1 = Reikšmė1, Stulpelis2 = Reikšmė2
        WHERE LentelėsPavadinimasStulpelis = LyginamaReikšmė.
        Sukurkite ProductService Update funkcionaluma. */

        public static void Task1()
        {
            Console.WriteLine("Fetching connection string...");
            var dbConfig = new DatabaseConfig();

            Console.WriteLine("Staring us Database check...");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check is COMPLETE.");

            INotebookWriter notebookWriter = new NotebookWriter();
            notebookWriter.Run();
        }
    }
}