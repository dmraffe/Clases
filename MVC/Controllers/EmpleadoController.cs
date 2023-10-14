using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            return View("equipo");
        }
        public IActionResult Equipo()
        {
            return View();
        }

    }
}
