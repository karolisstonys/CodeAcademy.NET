namespace L053_QueringSqliteDB
{
    public class Program
    {
        // SVARBU!!        
        // PAGRINDINES CLI(PACKAGE MANAGER CONSOLE) KOMANDOS:        
        // KOMANDOS TURI BUTI LEIDZIAMAS ANT INFRSTRUKTUROS PROJEKTO (Ten kur randasi DbContext)        
        // add-migration "*MigrationName*"        
        // update-database        
        // update-database "*MigrationName*"

        // Pradedi naudoti SQLite turime isirasyti siuos NuGet (Tools->NuGet Package Manager->Manage NuGet...)        
        // 1. install-package Microsoft.EntityFrameworkCore.Sqlite          // Infrastructure
        // 2. install-package Microsoft.EntityFrameworkCore.Proxies         // Infrastructure       
        // 3. install-package Microsoft.EntityFrameworkCore.Tools           // Presentation (Console app), Infrastructure

        // add-migration naudojame tada kada pasikeicia musu duombazes struktura



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}