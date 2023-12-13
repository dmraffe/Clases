using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seguridad.Identity.Models;

namespace Seguridad.Identity.DbContext
{
    public class IdentityDbContextSabado : IdentityDbContext<Usuario>
    {
        public IdentityDbContextSabado(DbContextOptions<IdentityDbContextSabado> options) :  base(options)
        {
        }

    }
}
