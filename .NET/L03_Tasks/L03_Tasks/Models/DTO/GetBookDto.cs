namespace L03_Tasks.Models.DTO
{
    public class GetBookDto : IGetBookDto
    {
        public int Id { get; set; }

        public string PavadinimasIrAutorius { get; set; }

        public int LeidybosMetai { get; set; }
    }
}
