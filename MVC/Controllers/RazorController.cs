using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
