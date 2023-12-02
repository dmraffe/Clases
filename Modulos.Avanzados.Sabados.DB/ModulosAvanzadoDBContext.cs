using Microsoft.EntityFrameworkCore;
using Modulos.Avanzado.Sabados.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos.Avanzados.Sabados.DB
{
    public  class ModulosAvanzadoDBContext : DbContext
    {
        public ModulosAvanzadoDBContext(DbContextOptions<ModulosAvanzadoDBContext> contextOptions) : base(contextOptions) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(a=>a.Direcciones)
                .WithOne(a=>a.Cliente)
                .HasForeignKey(a=>a.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pais>()
                .HasMany(a=>a.Ciudad)
                .WithOne(a=>a.Pais)
                .HasForeignKey(a=>a.PaisId)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Ciudad>()
                .HasMany(a=>a.Direccion)
                .WithOne(a=>a.Ciudad)
                .HasForeignKey(a=>a.CiudadId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false); 


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<Ciudad> Ciudades { get; set;}

    }
}
