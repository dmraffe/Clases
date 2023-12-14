using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Seguridad.MVC.Models;

namespace Seguridad.MVC.Controllers
{
    public class AuthController : Controller
    {

        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;   
        public AuthController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDTI loginDTI)
        {
            var user = await _userManager.FindByEmailAsync(loginDTI.Correo);

            var resultado = await _signInManager.PasswordSignInAsync(user.Email, loginDTI.Contraseña, false, lockoutOnFailure: false);

            if(resultado.Succeeded)
                return RedirectToAction("Index", "Home");   

            return View();
        }


        public IActionResult Registro()
        {
            _signInManager.SignOutAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(DTIRegistro dTIRegistro)
        {
            try
            {
                var user = new Usuario
                {
                    Apellido = dTIRegistro.Apellido,
                    Email = dTIRegistro.Correo,
                    Nombre = dTIRegistro.Nombre,
                    Cumpleaños = dTIRegistro.Cumpleaños ,
                    UserName = dTIRegistro.Correo



                };

                var result = await _userManager.CreateAsync(user, dTIRegistro.Contraseña);
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                var e = ex;
            }

            return View();
        }
    }
}
