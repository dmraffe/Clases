using Microsoft.AspNetCore.Mvc;
using Proyecto.Integrador.Aplicacions.Contratos.Servicio;
using Proyecto.Integrador.Infra.Implementacion.Servicio;
using Proyecto.Integrador.Web.Models;
using Proyecto.Integrador.Web.Models.DTO;
using System.Diagnostics;

namespace Proyecto.Integrador.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IServicioCategoria _servicioCategoria;
        IServicioProductos _servicioprod;

        public HomeController(ILogger<HomeController> logger, IServicioCategoria  servicioCategoria, IServicioProductos servicioprod)
        {
            _logger = logger;
            _servicioCategoria = servicioCategoria;
            _servicioprod = servicioprod;
        }

        public  async Task<IActionResult> Index()
        {
            HomeDto dt = new();
             
            dt.Categorias = await _servicioCategoria.GetCategoriasyProductos();
            dt.ProductosNuevos = await _servicioprod.GetProductosNuevos();
            return View(dt);
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