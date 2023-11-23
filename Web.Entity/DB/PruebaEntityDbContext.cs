using Microsoft.EntityFrameworkCore;
using Web.Entity.Models;

namespace Web.Entity.DB
{
    public class PruebaEntityDbContext  : DbContext
    {
        public PruebaEntityDbContext(DbContextOptions<PruebaEntityDbContext> option) :base(option)
        { 
        
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
