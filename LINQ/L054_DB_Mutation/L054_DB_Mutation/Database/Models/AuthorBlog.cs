﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L057_Db_TransactionChangeTracking.Domain.Models
{
    public class AuthorBlog
    {
        // Many to many relationship
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Blog Blog { get; set; }
    }
}