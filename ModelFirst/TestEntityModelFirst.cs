using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelFirst
{
    public partial class TestEntityModelFirst : DbContext
    {
        public TestEntityModelFirst()
            : base("name=TestEntityModelFirst")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Cateogorias> Cateogorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Ordenes> Ordenes { get; set; }
        public virtual DbSet<OrdenProductos> OrdenProductos { get; set; }
        public virtual DbSet<ProductoImagen> ProductoImagen { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .Property(e => e.Calificacion)
                .HasPrecision(18, 0);
        }
    }
}
