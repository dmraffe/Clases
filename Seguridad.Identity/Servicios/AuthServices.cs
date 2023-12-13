using Microsoft.AspNetCore.Identity;
using Seguridad.Identity.Models;
using System.IdentityModel.Tokens.Jwt;

namespace Seguridad.Identity.Servicios
{
    public class AuthServices : IAuthServices
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AuthServices(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Login(string username, string password)
        {
           var user = await _userManager.FindByEmailAsync(username);

            var resultado = await _signInManager.PasswordSignInAsync(user.UserName, password, false, lockoutOnFailure: false);
             

             

            return resultado.Succeeded;
        }

        public async Task<bool> Register(RegistrationRequest authRequest)
        {
            var existingUser = await _userManager.FindByNameAsync(authRequest.UserName);
            if (existingUser != null)
            {
                throw new Exception("Usuario repetido");
            }


            existingUser = await _userManager.FindByEmailAsync(authRequest.Email);
            if (existingUser != null)
            {
                throw new Exception("Usuario repetido");
            }

            var user = new Usuario
            {
                Email = authRequest.Email,
                Nombre = authRequest.Nombre,
                Apellido = authRequest.Apellido,
                UserName = authRequest.UserName,
                EmailConfirmed = false,
                UserHandle = authRequest.UserName


            };

            var result = await _userManager.CreateAsync(user, authRequest.Password);
            if (result.Succeeded)
            {
               /* await _userManager.AddToRoleAsync(user, "Operator");
                var tokem = await GenerateToken(user);
                return new RegistrationResponse
                {
                    Email = user.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(tokem),
                    UserId = user.Id,
                    UserName = user.UserName
                };*/

                return true;
            }
            throw new Exception($" {result.Errors}");
        }
    }


    public class RegistrationRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }



    }
}
