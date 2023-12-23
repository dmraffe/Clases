using Microsoft.EntityFrameworkCore;
using Proyecto.Integrador.Modelo.Tablas;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

            modelBuilder.Entity<Usuario>()
                .HasMany(a => a.Ordenes)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

          modelBuilder.Entity<Usuario>()
         .HasMany(a => a.Rates)
         .WithOne(a => a.Usuario)
         .HasForeignKey(a => a.UserId)
         .IsRequired()
         .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ordenes>()
             .HasOne(a => a.Rate)
             .WithOne(a => a.Ordenes)
             .HasForeignKey<Rate>(c => c.OrderId)
      .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Detalle> Detalles { get; set; }

        public DbSet<Ordenes> Ordenes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Rate> Rates { get; set; }


    }
}
