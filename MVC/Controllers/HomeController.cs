using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }                                                                          

        public IActionResult Index(string title)
        {
            SimpleModel model = new SimpleModel() { Value = title };

            ViewBag.Mensaje = model.Mensaje;
             return View(model);    
          /*   ViewBag.Titulo = "Clase de los sabados";
             ViewData["Title"] = "Clase de los sabados ViewData";
             return View();    */

           //return RedirectToAction("Index", "City");
        }


        [HttpGet, ActionName("mostrartexto")]

        public string ejemplo ()
        {

            return "Hola mundo";
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