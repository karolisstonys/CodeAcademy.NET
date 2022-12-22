﻿using Microsoft.IdentityModel.Tokens;
using P04_EF_Applying_To_API.Services.IServices;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace P04_EF_Applying_To_API.Services
{
    public class JwtService : IJwtService
    {
        private string _secretKey;
        public JwtService(IConfiguration conf)
        {
            _secretKey = conf.GetValue<string>("ApiSettings:Secret");
        }

        public string GetJwtToken(int userId, string role)
        {
            // To generate JWT token
            // 1. To generate a JWT token we need a secret.
            // 1.1 Key will be used to encrypt our message
            // 1.2 It will be used to verify/validate token
            // 1.3 Secret HAS to be known only to application
            // 1.4 Secret is used to sign and verify tokens

            // JWT structure: header.payload.signature
            // install-package Microsoft.AspNetCore.Authentication.JwtBearer -Version 6.0.11
            var tokenHandler = new JwtSecurityTokenHandler();

            // For token handler we need:
            // 1. A key(Which will be in bytes)
            var key = Encoding.ASCII.GetBytes(_secretKey);

            // 2. Token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                // Claim is required to identify WHO is the client/entity/person that is trying to use our application
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId.ToString()),
                    new Claim(ClaimTypes.Role, role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
