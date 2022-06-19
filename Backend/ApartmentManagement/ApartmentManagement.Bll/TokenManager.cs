using ApartmentManagement.Entity.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApartmentManagement.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateAccessToken(DtoLoginUser user)
        {
            // claim
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserUsername),
                new Claim(JwtRegisteredClaimNames.Jti, user.UserId.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            // claim roles
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                new Claim("role2", "User")
            };

            // security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            // şifrelenmiş kimlik oluşturma
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // token settings
            var token = new JwtSecurityToken
            (
                issuer: configuration["Tokens:Issuer"], // token dağıtıcı url
                audience: configuration["Tokens:Issuer"], // erişilebilecek apiler // audience olmadığı için issuer yazıldı
                expires: DateTime.Now.AddDays(1), // 1 günlük token
                notBefore: DateTime.Now, // token üretildekten ne kadar zaman sonra devreye girsin
                signingCredentials: cred, // kimlik verme
                claims: claimsIdentity.Claims // claims verme
            );

            // token oluşturma sınıfı ile örnek alıp üretmek
            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            return tokenHandler.token;
        }
    }
}
