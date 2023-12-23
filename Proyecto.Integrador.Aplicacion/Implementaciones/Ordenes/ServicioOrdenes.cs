using Proyecto.Integrador.Aplicacion.Contratos.Repositorio;
using Proyecto.Integrador.Aplicacion.Contratos.Servicios;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Aplicacion.Implementaciones.Ordenes
{


    public class ServicioOrdenes : IServicioOrdenes
    {

        IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Orden> baseRepositorio;

        IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.OrdenProducto> baseRepositorioOrdenProducto;
        public ServicioOrdenes(IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.Orden> baseRepositorio, IBaseRepositorioAsync<Proyecto.Integrador.Modelos.Tablas.OrdenProducto> baseRepositorioordenproducto)
        {
            this.baseRepositorio = baseRepositorio;
            baseRepositorioOrdenProducto = baseRepositorioordenproducto;
        }

        public async Task<Orden> GetOrdenCarrito(string CookieId )
        {
            var carritos = await baseRepositorio.GetAsync(a => a.CookieCarrito == CookieId && a.Estados != "Pagado");

            return carritos.FirstOrDefault();
        }

        public async Task<Orden> GuardarCarrito(int Producto, string cookie)
        {
            var carritos = await baseRepositorio.GetAsync(a => a.CookieCarrito == cookie);
            var carrito = carritos.FirstOrDefault();

            if (carrito  == null)
            {
                 carrito = new Orden();
                carrito.CookieCarrito = cookie;
                carrito.Estados = "EnCarrito";
                carrito.FechaCreado = DateTime.Now;
                carrito.FechaEditado = DateTime.Now;
                carrito.ActualizadoPor = string.Empty;
                carrito.CreadoPor = string.Empty;
                await baseRepositorio.AddAsync(carrito);

            }

            await baseRepositorioOrdenProducto.AddAsync(new OrdenProducto { 
              IdOrden = carrito.Id,
              IdProducto = Producto,
              FechaCreado = DateTime.Now,
              FechaEditado = DateTime.Now,
              ActualizadoPor = string.Empty,
              CreadoPor = string.Empty,
            });
            return carrito;

        }

        public async Task<Orden> GuardarOrdenCarrito(string CookieId)
        {
            var carritos = await baseRepositorio.GetAsync(a => a.CookieCarrito == CookieId);

            var carrito = carritos.FirstOrDefault();

            carrito.Estados = "Pagado";

            await baseRepositorio.UpdateAsync(carrito);
            return carrito;
        }
    }
}
