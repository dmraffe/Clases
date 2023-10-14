using ADOWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using ADOWEB.ADM;

namespace ADOWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string conexion;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            conexion = configuration.GetConnectionString("ConnectionString");
        }

        public IActionResult Index()
        {

            ADMArticulos objAdmArt = new ADMArticulos(conexion);
            return View(objAdmArt.TraerTodos());
        }

        
    }
}