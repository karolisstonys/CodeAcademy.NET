using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueringSqliteDB.Domain.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Column(Order = 2)]
        public decimal Rating { get; set; }

        [Column("BlogName", Order = 1)]
        public string Name { get; set; }


        public virtual List<Post> Posts { get; set; }

    }
}
