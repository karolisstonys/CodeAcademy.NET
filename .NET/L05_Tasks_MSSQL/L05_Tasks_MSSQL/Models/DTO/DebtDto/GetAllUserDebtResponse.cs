namespace L05_Tasks_MSSQL.Models.DTO.DebtDto
{
    public class GetAllUserDebtResponse
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public int LibraryBookID { get; set; }
        public DateTime BookTaken { get; set; }
    }
}
