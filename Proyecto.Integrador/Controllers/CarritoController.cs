using Microsoft.AspNetCore.Mvc;
using Proyecto.Integrador.Aplicacion;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Aplicacion.Implementaciones.Ordenes;

namespace Proyecto.Integrador.Controllers
{
    public class CarritoController : Controller
    {
        private IServicioOrdenes servicioordenes;

        public CarritoController(IServicioOrdenes _servicioOrdenes)
        {

            servicioordenes = _servicioOrdenes;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> addCarrito(int id)
        {

            string cookie = UtilCarrito.GetCarritoCookie(Request);
            await servicioordenes.GuardarCarrito(id, cookie);

            UtilCarrito.PurCarritoCookie(Response, cookie);
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Checkout()
        {
            string cookie = UtilCarrito.GetCarritoCookie(Request);
            await servicioordenes.GuardarOrdenCarrito( cookie);
            UtilCarrito.EliminarCarritoCookie(Response);
            return View();
        }
    }
}
