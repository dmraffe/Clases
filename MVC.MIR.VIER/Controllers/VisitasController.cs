using Microsoft.AspNetCore.Mvc;
using MVC.MIR.VIER.Contratos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC.MIR.VIER.Controllers
{
    public class VisitasController : Controller
    {
        IAdministradorArchivo administradorArchivo;

        public VisitasController(IAdministradorArchivo administradorArchivo)
        {
            this.administradorArchivo = administradorArchivo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult agregarcomentario()
        {
            return View();
        }

        public IActionResult listacomentario()
        {

            var listaarchivos = administradorArchivo.ObtenerVisitas();
            return View(listaarchivos);
        }

        public IActionResult GuardarDatos()
        {
            var Nombre = Request.Form["nombre"].ToString();
                                                                    
            var Comentarios = Request.Form["comentario"].ToString();

            
            administradorArchivo.GuardarDatosenelArchivo(new Models.Visita
            {
                Nombre = Nombre,
                Comentario = Comentarios,
                Id = Guid.NewGuid().ToString(),

            });


            return View();
        }

    }
}
