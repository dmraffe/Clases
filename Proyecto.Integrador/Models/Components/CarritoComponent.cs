using Microsoft.AspNetCore.Mvc;
using Proyecto.Integrador.Aplicacion;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Modelos.Tablas;

namespace Proyecto.Integrador.Models.Components
{
    public class CarritoViewComponent : ViewComponent
    {
        private IServicioOrdenes servicioordenes;

        public CarritoViewComponent(IServicioOrdenes _servicioOrdenes) {

           servicioordenes = _servicioOrdenes;
        }
      
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Orden orden = null;
              string id = UtilCarrito.GetCarritoCookieConsulta(Request);
            if(!string.IsNullOrEmpty(id))
            {
                orden = await servicioordenes.GetOrdenCarrito(id);
            }
            return View("index",orden);
        }


    }
}
