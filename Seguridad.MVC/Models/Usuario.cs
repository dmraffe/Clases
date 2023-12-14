using Microsoft.AspNetCore.Identity;

namespace Seguridad.MVC.Models
{

    public class Usuario : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}

        public DateTime Cumpleaños { get; set;}

        public ICollection<Ordenes> Ordenes { get; set; }
    }
}
