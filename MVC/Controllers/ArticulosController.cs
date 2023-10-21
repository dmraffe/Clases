using Microsoft.AspNetCore.Mvc;
using MVC.Adm;
using MVC.Models;

namespace MVC.Controllers
{
    public class ArticulosController : Controller
    {
        private IConfiguration _config;
        private AdmArticulos adm;

        public ArticulosController(IConfiguration configuration)
        {
            _config = configuration;
             adm = new Adm.AdmArticulos(_config);
        }
        public IActionResult Index()
        {
            var page = new MainPage();
            page.articulos = adm.TraerTodos();
            page.Titulo = "pagina principal";


            return View(page);
            
        }


        public IActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Alta(Models.Articulo articulo)
        {   
            adm.Alta(articulo);   
            return RedirectToAction("Index");
        }

        public IActionResult Baja(int id)
        {
            adm.Borrar(id);
            return RedirectToAction("Index");
              
        }


        public IActionResult Modificacion(int id)
        {
            var articulo = adm.TraerArticulo(id);
            return View(articulo);
        }

        [HttpPost]
        public IActionResult Modificacion(Models.Articulo articulo)
        {
            adm.Modificar(articulo);
            return RedirectToAction("Index");
        }

    }
}
