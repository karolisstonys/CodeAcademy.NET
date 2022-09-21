using L056_Db_Dapper.Models;

namespace L056_Db_Dapper.Database
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public IEnumerable<Product> Get();

        public int Delete(string name)

    }
}