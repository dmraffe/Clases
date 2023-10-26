using Microsoft.AspNetCore.Mvc;
using MVC.MIR.VIER.Implementacion;
using MVC.MIR.VIER.Models;

namespace MVC.MIR.VIER.Controllers
{
    public class ArticulosController : Controller
    {

        AdmArticulos AdmArticulos = new AdmArticulos();
        public IActionResult Index()
        {
            return View(AdmArticulos.TraerTodos());

        }

        public IActionResult Alta()
        {
            return View();
        }
        
        
        [HttpPost]
        public IActionResult Alta(IFormCollection coleccion)
        {
           
            Articulo articulo = new Articulo
            {   
                Descripcion = coleccion["descripcion"],
                Precio = decimal.Parse(coleccion["precio"].ToString())
            };
            AdmArticulos.Alta(articulo);
            return RedirectToAction("Index");
        }


        public IActionResult Modificacion(int Id)
        {
        
            Articulo articulo = AdmArticulos.TraerArticulo(Id);
            return View(articulo);
        } 


        [HttpPost]
public IActionResult Modificacion(IFormCollection coleccion) {
             
            Articulo articulo = new Articulo
            {
                Codigo = int.Parse(coleccion["codigo"].ToString()),
                Descripcion = coleccion["descripcion"].ToString(),
                Precio = decimal.Parse(coleccion["precio"].ToString())
            };
            AdmArticulos.Modificar(articulo);
            return RedirectToAction("Index");
        }


        public IActionResult Baja(int id)
        {
            AdmArticulos.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}
