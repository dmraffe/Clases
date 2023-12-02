using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado.Modelos.DBModel;
using EntityAvanzado.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace EntityAvanzado.Controllers
{
    public class DireccionesController : Controller
    {
        IBaseRepositorio<Cliente> BaseRepositorioCliente { get; set; }
        IBaseRepositorio<Direccion> BaseRepositorio { get; set; }

        public DireccionesController(IBaseRepositorio<Direccion> baseRepositorio, IBaseRepositorio<Cliente> _BaseRepositorioCliente)
        {
            BaseRepositorio = baseRepositorio;
            BaseRepositorioCliente = _BaseRepositorioCliente;
        }


        // GET: DireccionesController
        public async Task<ActionResult> Index(int idcliente)
        {
            var cliente = await BaseRepositorioCliente.Get(idcliente);
             var direcciones = await BaseRepositorio.GetAll(a=>a.ClienteID == idcliente, "Cliente");
            MoidelViewCris model = new(direcciones, cliente);
           
           
            ViewBag.idcliente = idcliente;
            return View(model);
        }

        // GET: DireccionesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var direccion = await BaseRepositorio.Get(id,"Cliente");
            return View(direccion);
        }

        // GET: DireccionesController/Create
        public ActionResult Create(int idcliente)
        {
            ViewBag.idcliente = idcliente;
            return View();
        }

        // POST: DireccionesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Direccion direccion)
        {
            try
            {
                await BaseRepositorio.Add(direccion);
                return RedirectToAction(nameof(Index), new {idcliente = direccion.ClienteID });
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: DireccionesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var direccion =  await BaseRepositorio.Get(id, "Cliente");
            return View(direccion);
        }

        // POST: DireccionesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Direccion direccion)
        {
            try
            {
                await BaseRepositorio.Update(direccion);
                return RedirectToAction(nameof(Index), new { idcliente = direccion.ClienteID });
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: DireccionesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var direccion = await BaseRepositorio.Get(id, "Cliente");
            return View(direccion);
        }

        // POST: DireccionesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Delete(int id, Direccion direccion)
        {
            try
            {
                await BaseRepositorio.Delete(direccion);
                return RedirectToAction(nameof(Index), new { idcliente = direccion.ClienteID });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
