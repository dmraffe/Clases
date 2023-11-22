using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.Price = 152;
            return View();
        }
    }
}
