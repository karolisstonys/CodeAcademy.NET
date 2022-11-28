using L05_Tasks_MSSQL.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L05_Tasks_MSSQL.Models
{
    public class Book
    {
        public Book() { }

        public Book(int id, string title, int publishYear)
        {
            Id = id;
            Title = title;
            PublishYear = publishYear;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public ECoverType? ECoverType { get; set; }
        public int PublishYear { get; set; }
    }
}
