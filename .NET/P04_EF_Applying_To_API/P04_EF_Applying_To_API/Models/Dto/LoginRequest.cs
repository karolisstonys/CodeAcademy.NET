﻿namespace P04_EF_Applying_To_API.Models.Dto
{
    public class LoginRequest
    {
        // Jei sitie duomenys sutaps, mes vartotojui atgal grazinam JWT
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
