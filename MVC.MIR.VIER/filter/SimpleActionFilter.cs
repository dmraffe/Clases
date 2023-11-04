using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MVC.MIR.VIER.Models;
using System.Diagnostics;

namespace MVC.MIR.VIER.filter
{
    public class SimpleActionFilter  :ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("This Event Fired: OnActionExecuting");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            ViewResult result = (ViewResult)filterContext.Result;
            var model = (SimpleModel)result.Model;
            Console.WriteLine("Result: " +model.Value);
            Console.WriteLine("This Event Fired: OnActionExecuted");
        }

    }
}
