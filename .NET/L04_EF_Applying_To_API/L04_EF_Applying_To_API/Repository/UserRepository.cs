﻿using L04_EF_Applying_To_API.Data;
using L04_EF_Applying_To_API.Models;
using L04_EF_Applying_To_API.Models.DTO;
using L04_EF_Applying_To_API.Repository.IRepository;
using L04_EF_Applying_To_API.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace L04_EF_Applying_To_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;
        private readonly LoginResponse _emptyTokenAndNullUser = new LoginResponse
        {
            Token = "",
            User = null
        };

        public UserRepository(RestaurantContext db, IConfiguration conf, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService=jwtService;
        }

        public async Task<bool> IsUniqueUserAsync(string username)
        {
            var user = await _db.LocalUsers.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null) return true;
            return false;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var inputPastwordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = await _db.LocalUsers.FirstOrDefaultAsync(u => u.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null) return _emptyTokenAndNullUser;

            if (_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) return _emptyTokenAndNullUser;

            var token = _jwtService.GetJwtToken(user.Id, user.Role);

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = user
            };

            loginResponse.User.PasswordHash = null;

            return loginResponse;
        }

        public async Task<RegistrationResponse> RegisterAsync(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] hash, out byte[] salt);

            LocalUser user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = hash,
                PasswordSalt = salt,
                Name = registrationRequest.Name,
                Role = registrationRequest.Role
            };

            RegistrationResponse registrationResponse = new()
            {
                Username = registrationRequest.Username,
                Name = registrationRequest.Name,
                Role = registrationRequest.Role
            };

            _db.LocalUsers.Add(user);
            await _db.SaveChangesAsync();

            return registrationResponse;
        }

        public async Task<bool> IsRegisteredAsync(int UserId)
        {
            var isRegistered = await _db.LocalUsers.AnyAsync(u => u.Id == UserId);
            return isRegistered;
        }
    }
}
