using System.Linq.Expressions;

namespace L07_Api_Car.Repository
{
    public interface IRepository<T> where T : class, new()
    {
        T Get(int id);

        IEnumerable<T> All();

        int Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        int Count();

        bool Exists(int id);

        IEnumerable<T> Find(Expression<Func<T, bool>> filter);
    }
}
