using Microsoft.EntityFrameworkCore;
using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Integrador.Infra.Persistencia
{
    public class TiendaMIaDbContext : DbContext
    {
        public TiendaMIaDbContext(DbContextOptions<TiendaMIaDbContext> options) : base(options) { 
        
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(a => a.Productos)
                .WithOne(a => a.Categoria)
                .HasForeignKey(a => a.CategoriaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Ordenes>()
                .HasMany(a => a.detalles)
                .WithOne(a => a.Orden)
                .HasForeignKey(a => a.OrdenId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Detalle> Detalles { get; set; }

        public DbSet<Ordenes> Ordenes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }



    }
}
