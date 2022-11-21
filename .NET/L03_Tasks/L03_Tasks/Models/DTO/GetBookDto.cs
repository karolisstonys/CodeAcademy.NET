namespace L03_Tasks.Models.DTO
{
    public class GetBookDto : IGetBookDto
    {
        public int Id { get; set; }

        public string TitleAndAuthor { get; set; }

        public int PublishYear { get; set; }
    }
}
