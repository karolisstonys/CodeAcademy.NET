namespace L05_Tasks_MSSQL.Models.DTO
{
    public class GetAuthorDto
    {
        public GetAuthorDto(Author author)
        {
            Id = author.Id;
            Name = author.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
