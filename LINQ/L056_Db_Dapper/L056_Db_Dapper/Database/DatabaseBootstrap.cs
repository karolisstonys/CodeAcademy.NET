using L056_Db_Dapper.Database.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper.Database
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

        }
    }
}
