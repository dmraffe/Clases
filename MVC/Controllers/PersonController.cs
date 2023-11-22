using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MVC.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [Route("Person/GetName")]
        [HttpGet]
        public IActionResult GetName()
        {
            return View("GetName");
        }
        [Route("Person/GetName")]
        [HttpPost]
        public IActionResult GetName(Person person)
        {

            var model = ModelState.IsValid;
            var errorscount = ModelState.ErrorCount;
            IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            if  (model == true)
            return View("ShowName", person);

            else
            {
                ViewBag.Error = allErrors;
                return View("GetNameCustom", person);

            }
  
        }

    }
}
