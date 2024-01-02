using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TechCareer.Models.Auth
{
    public class TechCareerTokenHandler
    {
        public TokenModel CreateAccessToken(string email)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, "zincirberivan"),

            };

            var token = new TokenModel();
            token.ExpireDate = DateTime.Now.AddMinutes(5);

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                               issuer: "zincirberivan@gmail.com",
                               audience: "zincirberivan2@gmail.com",
                               claims: claims,
                               expires: token.ExpireDate,
                               signingCredentials: credentials
                                );
            // bu classı kullanarak token oluşturuyoruz.
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();


            token.accessToken = tokenHandler.WriteToken(jwtSecurityToken);

            return token;
        }
    }
}
