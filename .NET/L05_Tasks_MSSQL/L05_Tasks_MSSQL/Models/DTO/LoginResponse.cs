namespace L05_Tasks_MSSQL.Models.DTO
{
    public class LoginResponse
    {
        public RegistrationResponse? User { get; set; }

        public string Token { get; set; }
    }
}
