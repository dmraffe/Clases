using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Contratos.Servicios
{
    public interface IServicioOrdenes
    {

        public  Task<Orden>  GetOrdenCarrito(string CookieId);

        public Task<Orden> GuardarOrdenCarrito(string CookieId);

        public Task<Orden> GuardarCarrito(int Producto, string cookie);

    }
}
