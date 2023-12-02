using EntityAvanzado.Modelos.DBModel;

namespace EntityAvanzado.Models
{
    public class MoidelViewCris
    {
        public ICollection<Direccion> Direcciones { get; set; }

        public Cliente Cliente { get; set; }

        public MoidelViewCris(ICollection<Direccion> direcciones, Cliente cliente)
        {
            Direcciones = direcciones;
            Cliente = cliente;
        }
    }
}
