using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace EntityAvanzado.Models
{
    public class MyExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine(context.Exception.Message);

        }
    }

}
