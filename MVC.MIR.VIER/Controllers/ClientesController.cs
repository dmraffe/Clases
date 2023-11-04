using Microsoft.AspNetCore.Mvc;
using MVC.MIR.VIER.Implementacion;
using MVC.MIR.VIER.Models;
using System.Drawing.Text;

namespace MVC.MIR.VIER.Controllers
{
    public class ClientesController : Controller
    {

        AdmClientes AdmClientes = new AdmClientes();
        public IActionResult Index(string param)
        {
            return View(AdmClientes.TraerTodos());
        }


        public IActionResult Details(int id)
        {
            return View(AdmClientes.TraerCliente(id));
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Cliente/Create
        [HttpPost]
        public IActionResult Create(Clientes  clientes)
        {
                AdmClientes.Alta(clientes);
                return RedirectToAction("Index");
           
        }


        public IActionResult Edit(int id)
        {
            return View(AdmClientes.TraerCliente(id));
        }
        // POST: Cliente/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Clientes clientes)
        {
            AdmClientes.Modificar(clientes);
            return RedirectToAction("Index");
   

        }


        // GET: Cliente/Delete/5
        public IActionResult Delete(int id)
        {
            return View(AdmClientes.TraerCliente(id));
        }
        // POST: Cliente/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, IFormCollection clientes)
        {
            AdmClientes.Borrar(id);
            return RedirectToAction("Index");
           
        }


    }
    }
