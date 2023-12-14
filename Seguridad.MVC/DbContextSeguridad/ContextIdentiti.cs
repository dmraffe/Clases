using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seguridad.MVC.Models;

namespace Seguridad.MVC.DbContextSeguridad
{
    public class ContextIdentit :  IdentityDbContext<Usuario>
    {
        public ContextIdentit(DbContextOptions<ContextIdentit> options) :base(options)
        {
        }
    }
}
