using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado.Modelos.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityAvanzado.Controllers
{
    public class ClienteController : Controller
    {

        IBaseRepositorio<Cliente>     BaseRepositorio { get; set; }

        public ClienteController(IBaseRepositorio<Cliente> baseRepositorio)
        {
            BaseRepositorio = baseRepositorio;
        }


        // GET: ClienteController
      
        public async Task<ActionResult> Index()
        {
            var listacliente = await BaseRepositorio.GetAll();
            return View(listacliente);
        }

        // GET: ClienteController/Details/5
        public async Task<ActionResult> Details(int id)
        {     var cliente = await BaseRepositorio.Get(id);
            return View(cliente);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Cliente cliente)
        {
            try
            {
                await BaseRepositorio.Add(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var cliente = await BaseRepositorio.Get(id);
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<ActionResult> Edit(int id, Cliente cliente)
        {
            try
            {
                await BaseRepositorio.Update(cliente);
                return RedirectToAction(nameof(Index));
             
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await BaseRepositorio.Get(id);
            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Cliente cliente)
        {
            try
            {
                await BaseRepositorio.Delete(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
