﻿using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Common.Helper
{
    public class TokenGenerator
    {
        public static JwtOptions options { get; set; } = null!;
        public static string GenerateToken(User user)
        {
            var claims = new ClaimsIdentity(new Claim[]
            {
            new Claim("UserId", user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            });

            if (user.UserRoles != null)
            {
                foreach (var userRole in user.UserRoles)
                {
                    claims.AddClaim(new Claim(ClaimTypes.Role, userRole.Role.Name));
                }
            }

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(options.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = options.Issuer,
                Audience = options.Audience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(options.ExpiryHours),
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        //public static RefreshToken GenerateRefreshToken()
        //{
        //    var randomNumber = new byte[32];

        //    using var generator = new RNGCryptoServiceProvider();

        //    generator.GetBytes(randomNumber);

        //    return new RefreshToken
        //    {
        //        Token = Convert.ToBase64String(randomNumber),
        //        ExpiresOn = DateTime.UtcNow.AddDays(10),
        //        CreatedOn = DateTime.UtcNow
        //    };
        //}
    }
}