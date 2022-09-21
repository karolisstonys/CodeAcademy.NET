using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper.Database.Dapper
{
    public class DatabaseConfig
    {
        public DatabaseConfig()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            string dbName = "ProductDapper.db";
            ConnString = "Data Source=" + Path.Join(path, dbName);
        }


        public string ConnString { get; }



    }
}
