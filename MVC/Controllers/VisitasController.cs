using Microsoft.AspNetCore.Mvc;
using MVC.Contratos;
using MVC.Models;

namespace MVC.Controllers
{
    public class VisitasController : Controller
    {
        IRepositorioArchivo _repositorioArchivo;

        public VisitasController(IRepositorioArchivo repositorioArchivo)
        {
            _repositorioArchivo = repositorioArchivo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult CargardDatos()
        {
            var comentario = new Models.Comentario()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = Request.Form["nombre"].ToString(),
                Comentarios = Request.Form["comentario"].ToString()
            };
            _repositorioArchivo.GuardarDatos(comentario);
            return View(comentario);
        }

        public IActionResult ListaFormulario()
        {
         var lista =   _repositorioArchivo.ObtenerComentario();
            return View(lista);
        }


        public IActionResult Ver(string id)
        {
            var cometario = _repositorioArchivo.ObtenerComentarioPorId(id);
            return View(cometario);
        }

    }
}
