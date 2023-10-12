using Microsoft.AspNetCore.Mvc;

namespace MVC.MIR.VIER.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return Content(@"<html><body><h1> ACME S.R.L.</h1><p> Una organización a su servicio, para resolver  cualquier problema </p>  <p>Juan Gomez<br>Pedro Martinez<br>Carla  Perez</p></body></html>", "text/html");
        }
    }
}
