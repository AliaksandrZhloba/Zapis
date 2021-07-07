using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

using Zapis.Helpers;


namespace Zapis.Services.JwtSecurity
{
    public class JwtSecurityService
    {
        private readonly JwtBearerSettings _jwtBearerSettings;


        public JwtSecurityService(JwtBearerSettings jwtBearerSettings)
        {
            _jwtBearerSettings = jwtBearerSettings;
        }


        public JwtAuthResult GenerateJSONWebToken(string username, string role)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            }; 

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtBearerSettings.SecurityKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                _jwtBearerSettings.Issuer,
                _jwtBearerSettings.Audience,
                claims,
                expires: DateTime.Now.AddSeconds(_jwtBearerSettings.AccessTokenExpiration),
                signingCredentials: credentials);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);
    
            return new JwtAuthResult()
            {
                AccessToken = accessToken
            };
        }
    }
}