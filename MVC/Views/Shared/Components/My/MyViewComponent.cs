using Microsoft.AspNetCore.Mvc;

namespace MVC.Views.Shared.Component.Partial
{
    public class MyViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {

            ViewBag.ResultadoRealMadrid = "Esta sin jugar";
            return Task.FromResult<IViewComponentResult>(View("Default"));
        }

    }
}
