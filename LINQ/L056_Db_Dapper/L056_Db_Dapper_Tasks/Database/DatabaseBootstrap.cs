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
                Id [INT IDENTITY(1,1) PRIMARY KEY] NOT NULL,
                Title VARCHAR(80) NULL,
                Description VARCHAR(1000) NULL,
                CreationDatetime DATE NULL,
                Priority VARCHAR(100) NULL)");
        }
    }
}
