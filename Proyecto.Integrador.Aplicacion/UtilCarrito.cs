using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion
{
    public static class UtilCarrito
    {
        public static string carritocokie = "carrito";


        public static string GetCarritoCookieConsulta(HttpRequest Request)
        {
            if (Request.Cookies.Any(a => a.Key == carritocokie))
            {
                return Request.Cookies[carritocokie];
            }


            return null;
        }
        public static string GetCarritoCookie(HttpRequest Request)
        { 
             if(Request.Cookies.Any(a=>a.Key == carritocokie))
            {
                return Request.Cookies[carritocokie];
            }


            return Guid.NewGuid().ToString();
        }

        public static void PurCarritoCookie(HttpResponse Response,string valor)
        {
            Response.Cookies.Append(carritocokie, valor);
        }

        public static void EliminarCarritoCookie(HttpResponse Response)
        {
            Response.Cookies.Delete(carritocokie);
        }


    }
}
