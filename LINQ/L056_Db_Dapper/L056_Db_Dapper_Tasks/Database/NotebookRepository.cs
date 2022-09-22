using Dapper;
using L056_Db_Dapper_Tasks.Database.Dapper;
using L056_Db_Dapper_Tasks.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper_Tasks.Database
{
    public class NotebookRepository : INotebookRepository
    {

        private readonly DatabaseConfig _databaseConfig;

        public NotebookRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Create(Notebook notebook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO Notebook (Title, Description, Priority)
                VALUES (@Title, @Description, @Priority);", notebook);
        }

        public IEnumerable<Notebook> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            return connection.Query<Notebook>(@"
                SELECT *
                FROM Notebook");
        }

        public int Delete(string notebookTitle)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var affectedRows = connection.Execute(@"
                DELETE
                FROM Notebook
                WHERE Title = @Title;", new { Title = notebookTitle });

            return affectedRows;
        }

        /* Uzduotis 1.3 Pridėkite galimybę atnaujinti įrašus. Naudokite Dapper Execute() metodą. SQL UPDATE sintaksė:
        UPDATE LentelėsPavadinimas
        SET Stulpelis1 = Reikšmė1, Stulpelis2 = Reikšmė2
        WHERE LentelėsPavadinimasStulpelis = LyginamaReikšmė.
        Sukurkite ProductService Update funkcionaluma. */

        public void Update(Notebook notebook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var updateQuery = @"
                UPDATE Notebook
                SET Title = @Title
                ,Description = @Description
                ,Priority = @Priority
                WHERE Id = @Id;";

            connection.Execute(updateQuery, notebook);

        }

        public Notebook Get(int notebookId)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            return connection.Query<Notebook>(@"
                SELECT *
                FROM Notebook
                WHERE Id = @Id;", new { Id = notebookId })
                .FirstOrDefault();
        }
    }
}
