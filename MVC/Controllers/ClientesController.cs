using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Adm;
using MVC.Models;

namespace MVC.Controllers
{
    public class ClientesController : Controller
    {

        private IConfiguration _config;
        private AdmCLientes adm;

        public ClientesController(IConfiguration configuration)
        {
            _config = configuration;
            adm = new Adm.AdmCLientes(_config);
        }
        // GET: ClientesController
        public ActionResult Index()
        {

            return View(adm.TraerTodos());
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            var cl = adm.TraerCliente(id);
            return View(cl);
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
              
                Clientes cliente = new Clientes 
                {
                    Nombre = collection["nombre"],
                    Apellido = collection["apellido"],
                    Email = collection["email"]
                };
                adm.Alta(cliente);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            var cl = adm.TraerCliente(id);
            return View(cl);
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {

                Clientes cliente = new Clientes
                {
                    Id = id,
                    Nombre = collection["nombre"],
                    Apellido = collection["apellido"],
                    Email = collection["email"]
                };
                adm.Modificar(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            var cl  = adm.TraerCliente(id);
            return View(cl);
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                 adm.Borrar(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
