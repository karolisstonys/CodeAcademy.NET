using L057_Db_TransactionChangeTracking.Database.Models;

namespace L057_Db_TransactionChangeTracking.Database.Models
{
    public class AuthorBlog
    {
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Author Author { get; set; }

    }
}
