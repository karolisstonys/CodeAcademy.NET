using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace L05_Tasks_MSSQL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BookStoreContext _db;
        private DbSet<TEntity> _dbSet;

        public Repository(BookStoreContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, bool tracked = true)
        {
            IQueryable<TEntity> query = _dbSet;
            if (!tracked) query = query.AsNoTracking();
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null) query = query.Where(filter);
            return query.ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
            Save();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
