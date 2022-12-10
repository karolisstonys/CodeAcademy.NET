using System.ComponentModel.DataAnnotations;

namespace L05_Tasks_MSSQL.Models
{
    public class LibraryBook
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public bool IsTaken { get; set; }
        public IEnumerable<UserBook>? UserBooks { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
