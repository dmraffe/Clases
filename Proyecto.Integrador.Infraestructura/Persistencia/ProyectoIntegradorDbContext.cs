using Microsoft.EntityFrameworkCore;
using Proyecto.Integrador.Modelos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infraestructura.Persistencia
{
    public class ProyectoIntegradorDbContext : DbContext
    {

        public ProyectoIntegradorDbContext(DbContextOptions<ProyectoIntegradorDbContext> options) : base(options) { 
        }


        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Orden> Ordenes { get; set; }

        public DbSet<OrdenProducto> OrdenProductos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Producto> Productos { get; set; }


    }
}
