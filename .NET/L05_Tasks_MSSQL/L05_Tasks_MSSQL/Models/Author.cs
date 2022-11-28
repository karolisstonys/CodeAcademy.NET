using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L05_Tasks_MSSQL.Models
{
    public class Author
    {
        public Author() { }

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
