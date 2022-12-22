using L05_Tasks_MSSQL.Models.DTO.UserDto;

namespace L05_Tasks_MSSQL.Models.DTO
{
    public class LoginResponse
    {
        public GetUserDto? User { get; set; }

        public string Token { get; set; }
    }
}
