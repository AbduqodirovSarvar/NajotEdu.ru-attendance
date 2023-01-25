using Microsoft.IdentityModel.Tokens;
using NajotEdu.ru.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace NajotEdu.ru.Servis
{
    public class JWTService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public JWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetToken(string username)
        {

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Name, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString())
            };
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["localhost"])),
                SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token).ToString();

        }
    }
}
