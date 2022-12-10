using L05_Tasks_MSSQL.Models;

namespace L05_Tasks_MSSQL.Repository.IRepository
{
    public interface IUserBookRepository : IRepository<UserBook>
    {
        UserBook Update(UserBook userBook);
    }
}
