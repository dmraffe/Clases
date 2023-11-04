using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Page"] = "Search city";
            return View();
        }


        public IActionResult Detalles(int? id )
        {
            Citys citys = null;
            if (citys == null)
            {
                return NotFound();
            }

            ViewData["Page"] = "Selected city";
            return View();
            
        }


        public IActionResult GetImage(int? id)
        {
            Citys requestedCity = null;

            if (requestedCity != null)
            {
               string path  = string.Empty;
                FileStream fileOnDisk = new FileStream(path, FileMode.Open, FileAccess.Read);
                Byte[] filebyte  ;

                using (BinaryReader br = new BinaryReader(fileOnDisk))
                {
                    filebyte = br.ReadBytes((int)fileOnDisk.Length);
                    File(filebyte, "image");
                }
            }else
            {
                return NotFound();
            }
            ViewData["Page"] = "Display Image";
            return View();
        }
    }
}
