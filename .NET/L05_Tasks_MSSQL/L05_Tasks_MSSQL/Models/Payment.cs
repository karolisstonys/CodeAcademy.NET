namespace L05_Tasks_MSSQL.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Time { get; set; }
        public double Amount { get; set; }
        public string PointsUsed { get; set; }
    }
}
