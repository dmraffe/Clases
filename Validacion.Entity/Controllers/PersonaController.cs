using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validacion.Entity.BasedeDatos;
using Validacion.Entity.Models;

namespace Validacion.Entity.Controllers
{
    public class PersonaController : Controller
    {

        EntityTestDbContext Context { get; set; }

        public PersonaController(EntityTestDbContext context)
        {
            Context = context;
        }


        // GET: PersonaController
        public ActionResult Index()
        {
            return View(Context.Personas.ToList());
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            var person = Context.Personas.Where(a=>a.Id == id).FirstOrDefault();
            return View(person);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View("Createrazor");
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persona persona)
        {
            if(ModelState.IsValid)
            {
                Context.Personas.Add(persona);
                Context.SaveChanges();
                return View("Details", persona);
            }
            else
            {
                return View("Createtag");
            }

        }



        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            var person = Context.Personas.Where(a => a.Id == id).FirstOrDefault();
            return View(person);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Persona persona)
        {
            try
            {
                var isok = ModelState.IsValid;

                if (isok)
                {

                
                Context.Personas.Update(persona);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
                }else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            var person = Context.Personas.Where(a => a.Id == id).FirstOrDefault();
            return View(person);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Persona persona)
        {
            try
            {
                Context.Personas.Remove(persona);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
