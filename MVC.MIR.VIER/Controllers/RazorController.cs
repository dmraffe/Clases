using Microsoft.AspNetCore.Mvc;

namespace MVC.MIR.VIER.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cursos()
        {

            return View();
        }
    }
}
