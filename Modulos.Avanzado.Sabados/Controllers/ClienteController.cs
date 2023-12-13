using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Servicios;

namespace Modulos.Avanzado.Sabados.Controllers
{        

 


    public class ClienteController : Controller
    {

        IServicioCliente servicioCliente { get; set; }
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(IServicioCliente servicioCliente, ILogger<ClienteController> logger)
        {
            this.servicioCliente = servicioCliente;
            _logger = logger;
        }


        // GET: ClienteController
        public async Task<ActionResult> Index()
        {     try
            {
                int i = int.Parse("asd");
            }catch(Exception ex)
            {
                _logger.LogCritical(ex, ex.Message, null);
            }
            
           var allcliente = await this.servicioCliente.GetAll();
            return View(allcliente);
        }

        // GET: ClienteController/Details/5
        public async Task<ActionResult> Details(int id)
        {
           var cliente =  await this.servicioCliente.GetCliente(id);
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
             var result =    await this.servicioCliente.AddCliente(cliente);

                 if (result) 
                return RedirectToAction(nameof(Index));
                  else
                {
                    ViewBag.Error = "Cliente ya existe";
                    return View(cliente);
                }
              
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var cliente = await this.servicioCliente.GetCliente(id);
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Cliente cliente)
        {
            try
            {
                await this.servicioCliente.UpdateCliente(cliente);
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
            var cliente = await this.servicioCliente.GetCliente(id);
            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Cliente cliente)
        {
            try
            {
               await  this.servicioCliente.DelteCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
