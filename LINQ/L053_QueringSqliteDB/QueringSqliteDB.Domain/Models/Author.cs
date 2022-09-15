using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueringSqliteDB.Domain.Models
{
    //[Table ("Authors")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        public virtual IList<AuthorBlog> AuthorBlogs { get; set; }







    }
}
