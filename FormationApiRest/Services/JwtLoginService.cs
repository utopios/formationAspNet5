using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FormationApiRest.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace FormationApiRest.Services
{
    public class JwtLoginService : ITokenGenerator
    {
        public JwtLoginService()
        {
        }

        public string GenerateToken(string userName, string password)
        {
            if(userName == "ihab" && password == "123456")
            {
                //Generer le token
                //objet pour signer les données de à l'interieur de notre token
                SigningCredentials signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Hello it's our private key")),SecurityAlgorithms.HmacSha256);

                //données à stocker dans le token
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, "ihab@utopios.net"),
                    new Claim(ClaimTypes.Name, "ihab"),
                    new Claim(ClaimTypes.Role, "public")
                };

                //Gener le token
                JwtSecurityToken jwt = new JwtSecurityToken(issuer:"utopios", audience:"utopios", claims:claims, signingCredentials:signingCredentials, expires:DateTime.Now.AddDays(2));
                return new JwtSecurityTokenHandler().WriteToken(jwt);
            }
            return null;
        }


        
    }
}
