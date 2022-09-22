using Dapper;
using L056_Db_Dapper_Tasks.Database.Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper_Tasks.Database
{
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;

        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Setup()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var table = connection.Query<string>(@"
            SELECT name
            FROM sqlite_master
            WHERE type = 'table'
                AND name = 'Note';");

            var tableName = table.FirstOrDefault();

            if (!string.IsNullOrEmpty(tableName) && tableName == "Note") return;

            connection.Execute(@"
                CREATE TABLE Note (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title VARCHAR(100) NOT NULL,
                Description VARCHAR(1000) NULL,
                CreationDatetime DATETIME DEFAULT current_timestamp,
                Priority VARCHAR(100) DEFAULT 0)");
        }
    }
}
