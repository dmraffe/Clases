using Microsoft.AspNetCore.Mvc;

namespace MVC.MIR.VIER.Views.Shared.Components
{
    public class MyViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult<IViewComponentResult>(View("Default"));
        }
    }
}
