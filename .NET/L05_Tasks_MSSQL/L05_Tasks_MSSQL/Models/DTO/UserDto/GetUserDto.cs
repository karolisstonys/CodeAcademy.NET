namespace L05_Tasks_MSSQL.Models.DTO.UserDto
{
    public class GetUserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public int TakenLibraryBooks { get; set; }
        public int BooksNotReturnedInTime { get; set; }
        public double TotalDebt { get; set; }
    }
}
