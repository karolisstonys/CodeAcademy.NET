﻿namespace L05_Tasks_MSSQL.Models.DTO
{
    public class RegistrationRequest
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
