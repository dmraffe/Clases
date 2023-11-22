using Microsoft.EntityFrameworkCore;
using Validacion.Entity.Models;

namespace Validacion.Entity.BasedeDatos
{
    public class EntityTestDbContext : DbContext
    {
        public EntityTestDbContext(DbContextOptions<EntityTestDbContext> options) :base(options)
        {

    
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
