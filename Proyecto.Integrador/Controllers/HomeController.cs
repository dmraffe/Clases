using Microsoft.AspNetCore.Mvc;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Aplicacion.Implementaciones.Producto;
using Proyecto.Integrador.Modelos.DTO;
using Proyecto.Integrador.Models;
using System.Diagnostics;

namespace Proyecto.Integrador.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IservicioCategoria Categoria { get; set; }
        IServicioProductos _servicioProductos;
        public HomeController(ILogger<HomeController> logger, IservicioCategoria categoria, IServicioProductos servicioProductos)
        {
            _logger = logger;
            Categoria = categoria;

            _servicioProductos = servicioProductos;
         }

        public async Task<IActionResult> Index()
        {
             
            HomeDto hodto = new();
                 
            hodto.Categorias = await Categoria.ObtenerTodo();
            hodto.Nuevos = await _servicioProductos.ProductosNuevos();
            hodto.Vendidos = await _servicioProductos.ProductosMasVendidos();
            hodto.Tops = await _servicioProductos.ProductosTops();
            return View(hodto);
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