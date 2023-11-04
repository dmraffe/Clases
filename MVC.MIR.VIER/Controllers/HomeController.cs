using Microsoft.AspNetCore.Mvc;
using MVC.MIR.VIER.filter;
using MVC.MIR.VIER.Models;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace MVC.MIR.VIER.Controllers
{

   // [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

      
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[controller]/index/{param1}/{param2?}")]
        [SimpleActionFilter]
        public IActionResult Index(string param1, string? param2)
        {
            ViewBag.Title = "Home";
            ViewBag.Footer = "Footer";
            ViewBag.Etc = "etc";

           

            var controller = (string)RouteData.Values["controller"];


            ViewData["Data"] = "Data";
            var model = new SimpleModel() { Value = param2 };
           
           
            return View(model);
        }

        [Route("save-cliente")]

        [HttpPost]
        public IActionResult Index2(RegistroCliente registroCliente,string? title)
        {

            var model = new SimpleModel() { Value = "My value" };
            return Ok();
        }
        public IActionResult Equipo()
        {

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
    }
}