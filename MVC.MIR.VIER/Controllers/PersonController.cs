using Microsoft.AspNetCore.Mvc;
using MVC.MIR.VIER.Models;

namespace MVC.MIR.VIER.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    
       

        [HttpPost] 
        public IActionResult Index(Person person)
        {
            return View(person);

        }


        [Route("Person/GetName")]
        [HttpGet]
        public IActionResult GetName()
        {
            return View();
        }
        [Route("Person/GetName")]
        [HttpPost]
        public IActionResult GetName(Person person)
        {
            return View("ShowName", person);
        }
    }


}
