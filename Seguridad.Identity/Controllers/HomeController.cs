using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Seguridad.Identity.Models;
using Seguridad.Identity.Servicios;
using System.Diagnostics;

namespace Seguridad.Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IAuthServices authServices { get; set; }
        public HomeController(ILogger<HomeController> logger, IAuthServices authServices)
        {
            _logger = logger;
            this.authServices = authServices;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Nombre = User.Identity.Name;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> Registro(RegistrationRequest registrationRequest)
        {
            var reslresgitro = await this.authServices.Register(registrationRequest);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(LoginViewModel loginview)
        {
            var reslresgitro = await this.authServices.Login(loginview.Username, loginview.Password);
            return RedirectToAction("Index");
        }

    }
}