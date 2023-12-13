using Microsoft.AspNetCore.Identity;

namespace Seguridad.Identity.Models
{
    public class Usuario : IdentityUser
    {

        public string UserHandle { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

    }
}
