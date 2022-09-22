﻿using System.Collections.Generic;
using L057_Db_TransactionChangeTracking.Database.Models;

namespace L057_Db_TransactionChangeTracking.Database.Models
{
    public class Blog
    {
        public virtual int BlogId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Rating { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>(); //Lazy loading

        public virtual IList<AuthorBlog> AuthorBlog { get; set; }
    }
}
