using Microsoft.EntityFrameworkCore;
using Seguridad.MVC.Models;

namespace Seguridad.MVC.DbContextSeguridad
{
    public class DbContextApp : DbContext
    {
        public DbContextApp(DbContextOptions<DbContextApp> options) : base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(a => a.Ordenes)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


            

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Ordenes> Ordenes { get; set; }
    }
}
