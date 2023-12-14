using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ejemplo.JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {


        public string GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("PDv7DrqznYL6nv7DrqzjnQYO9JxIsWdcjnQYL6nu0f"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Name, "javier"),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                  new Claim("TipodeUsuario","Admin"),


            };

            var token = new JwtSecurityToken(
                issuer: "http://localhost:55789/",
                audience: "http://localhost:55789/",
                claims: claims,
                expires: DateTime.Now.AddMinutes(1440),
                signingCredentials: credentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }


        [Route("GetToken")]
        public IActionResult GetToken(string nombre)
        {

            if(nombre == "Dixon")
                return Ok(GenerateToken());

            return Ok("asdasdas");
        }

        [Route("ConPermiso")]
        [Authorize(Roles = "admin") ]
        public IActionResult ConPermiso()
        {
            var valor = User.Claims.FirstOrDefault(a => a.Type.Equals("TipodeUsuario"));
          

            return Ok(valor.Value);
        }

    }
}
