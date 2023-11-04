using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EjercicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display()
        {
            return View();
        }

        public IActionResult Getimage(string filename)
        {
            return View();
        }
    }
}
