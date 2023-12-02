using EntityAvanzado.Modelos.DBModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvanzado 
{
    public class EntityAvanzadoDBContext  : Microsoft.EntityFrameworkCore.DbContext
    {

        public EntityAvanzadoDBContext(DbContextOptions<EntityAvanzadoDBContext> options)  : base(options) { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(a => a.Direcciones)
                .WithOne(a => a.Cliente)
                .HasForeignKey(a => a.ClienteID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Categoria>()
                .HasMany(a=>a.Productos)
                .WithOne(a=>a.Categoria)
                .HasForeignKey(a=>a.CategoriaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<Categoria > Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
