using System.ComponentModel.DataAnnotations;

namespace L05_Tasks_MSSQL.Models
{
    public class UserBook
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int LibraryBookId { get; set; }
        public LibraryBook LibraryBook { get; set; }
        public DateTime BookTaken { get; set; }
        public DateTime BookReturned { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
