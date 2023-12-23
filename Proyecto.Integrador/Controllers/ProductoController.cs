using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;

namespace Proyecto.Integrador.Controllers
{
    public class ProductoController : Controller
    {
        IServicioProductos servicioProductos;


        public ProductoController(IServicioProductos _servicioProductos )
        {
            servicioProductos = _servicioProductos;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detalle(int id)
        {
            var pro = await servicioProductos.ObtenerProductoPorID(id);
            return View(pro);
        }

    }
}
