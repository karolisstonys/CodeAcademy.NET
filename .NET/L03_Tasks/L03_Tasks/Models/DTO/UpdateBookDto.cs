namespace L03_Tasks.Models.DTO
{
    public class UpdateBookDto
    {
        public int Id { get; set; }

        public DateTime Published { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string BookType { get; set; }

    }
}
