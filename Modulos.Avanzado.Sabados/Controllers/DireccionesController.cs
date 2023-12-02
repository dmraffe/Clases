using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Models;
using Modulos.Avanzado.Sabados.Servicios;

namespace Modulos.Avanzado.Sabados.Controllers
{
    public class DireccionesController : Controller
    {
        // GET: DireccionesController

        IServicioCliente servicioCliente { get; set; }
        IServiceDirecciones serviceDirecciones { get; set; }

        IServicioPais ServicioPais { get; set; }

        IServicioCiudadcs ServicioCiudad { get; set; }

        public DireccionesController(IServicioCliente servicioCliente, IServiceDirecciones serviceDirecciones,IServicioPais servicioPais, IServicioCiudadcs servicioCiudad)
        {
            this.servicioCliente = servicioCliente;
            this.serviceDirecciones = serviceDirecciones;
            this.ServicioPais = servicioPais;
            ServicioCiudad = servicioCiudad;
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
        public async Task<ActionResult> Create(int ClienteID)
        {
            ViewBag.ClienteID = ClienteID;

            var paises = await this.ServicioPais.getAll();
            var modelo = new DireccionesDTI(paises);
            return View(modelo);
        }

        // POST: DireccionesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DireccionesDTI direcciondti)
        {
            try
            {
                var direccion = new Direccion();

                direccion.Provincia = direcciondti.Provincia;
                direccion.Apartamento = direcciondti.Apartamento;
                direccion.Calle = direcciondti.Calle;
                direccion.CiudadId = direcciondti.CiudadId;
                direccion.NumerodeCalle = direcciondti.NumerodeCalle;
                direccion.ClienteId = direcciondti.ClienteId;
                direccion.Pais = string.Empty;
                await serviceDirecciones.Add(direccion);
                return RedirectToAction("Index", new { id = direccion.ClienteId });
            }
            catch(Exception ex)
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


        public async Task<ActionResult> getciudades(int pais)
        {
            var ciudades = await ServicioCiudad.getAllByPaisId(pais); 
            return Json(ciudades);
        }
    }
}
