using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Servicios;

namespace Modulos.Avanzado.Sabados.Controllers
{
    public class DireccionesController : Controller
    {
        // GET: DireccionesController

        IServicioCliente servicioCliente { get; set; }
        IServiceDirecciones serviceDirecciones { get; set; }

        public DireccionesController(IServicioCliente servicioCliente, IServiceDirecciones serviceDirecciones)
        {
            this.servicioCliente = servicioCliente;
            this.serviceDirecciones = serviceDirecciones;
        }

        public async Task<ActionResult> Index(int id)
        {
            var clien = await servicioCliente.GetClienteyDirecciones(id);

            ViewBag.NombreCliente = clien.Nombre;
            ViewBag.ClienteID = id;
            return View(clien.Direcciones);
        }

        // GET: DireccionesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var direccion = await serviceDirecciones.GetById(id,"Cliente");
            return View(direccion);
        }

        // GET: DireccionesController/Create
        public ActionResult Create(int ClienteID)
        {
            ViewBag.ClienteID = ClienteID;
            return View();
        }

        // POST: DireccionesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Direccion direccion)
        {
            try
            {
                await serviceDirecciones.Add(direccion);
                return RedirectToAction("Index", new { id = direccion.ClienteId });
            }
            catch
            {
                return View();
            }
        }

        // GET: DireccionesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var direccion = await serviceDirecciones.GetById(id);
            return View(direccion);

        }

        // POST: DireccionesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Direccion direccion)
        {
            try
            {
                await serviceDirecciones.Update(direccion);
                return RedirectToAction("Index", new { id = direccion.ClienteId });
            }
            catch
            {
                return View();
            }
        }

        // GET: DireccionesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var direccion = await serviceDirecciones.GetById(id);
            return View(direccion);
        }

        // POST: DireccionesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Direccion direccion)
        {
            try
            {
                await serviceDirecciones.Delete(direccion);
                return RedirectToAction("Index", new { id = direccion.ClienteId });
            }
            catch
            {
                return View();
            }
        }
    }
}
