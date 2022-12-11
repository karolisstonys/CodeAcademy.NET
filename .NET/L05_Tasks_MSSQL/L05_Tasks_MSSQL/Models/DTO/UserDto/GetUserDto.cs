namespace L05_Tasks_MSSQL.Models.DTO.UserDto
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public int TakenLibraryBooks { get; set; }
    }
}
