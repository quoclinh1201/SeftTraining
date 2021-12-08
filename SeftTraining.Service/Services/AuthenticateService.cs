using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SeftTraining.Business.IServices;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private IConfiguration _config;

        public AuthenticateService(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(int id, string username, string role)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                    new Claim(JwtRegisteredClaimNames.Sub, _config["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("Id", id.ToString()),
                    new Claim("Username", username),
                    new Claim(ClaimTypes.Role, role)
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                                            _config["Jwt:Issuer"],
                                            claims,
                                            expires: DateTime.Now.AddHours(24),
                                            signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
