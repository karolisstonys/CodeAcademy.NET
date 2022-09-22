using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L057_Db_TransactionChangeTracking.Database.Models;
using L057_Db_TransactionChangeTracking.Services;

namespace L057_Db_TransactionChangeTracking.Services
{
    public class BlogService
    {
        private readonly ManageDb _manageDb;

        public BlogService(ManageDb manageDb)
        {
            _manageDb = manageDb;
        }

        public List<Blog> GetBlogs()
        {
            var res = _manageDb.GetBlogs();
            //sakykime cia kazkokia logika
            return res;
        }

    }
}
