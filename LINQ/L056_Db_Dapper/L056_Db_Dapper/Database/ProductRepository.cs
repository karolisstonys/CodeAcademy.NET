using Dapper;
using L056_Db_Dapper.Database.Dapper;
using L056_Db_Dapper.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper.Database
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public ProductRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Create(Product product)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO Product (Name, Description)
                VALUES (@Name, @Description);", product);
        }

        public IEnumerable<Product> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // SELECT rowid AS Id -> Traukiam rowid, bet pervadinam ir grazinam Id pavadinimu
            // rowid yra SQLite sugebejimas rasti kurioje eiluteje mes randame irasa
            return connection.Query<Product>(@"
                SELECT rowid AS Id, Name, Description
                FROM Product");
        }

        public int Delete(string productName)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // DELETE -> norim istrinti viska eiluteje/eilutese
            // FROM Product -> Is Product lenteles
            var affectedRows = connection.Execute(@"
                DELETE
                FROM Product
                WHERE Name = @Name;", new { Name = productName });

            return affectedRows;
        }

    }
}
