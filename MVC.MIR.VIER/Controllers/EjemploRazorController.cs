using Microsoft.AspNetCore.Mvc;

namespace MVC.MIR.VIER.Controllers
{
    public class EjemploRazorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Price = 1525414;
            return View();
        }

        public IActionResult IndexTest()
        {
            ViewBag.Price = 1525414;
            return View();
        }
    }
}
