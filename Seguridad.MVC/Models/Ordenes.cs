namespace Seguridad.MVC.Models
{
    public class Ordenes
    {

        public int ID { get; set; }

        public decimal Total { get; set; }

        public string UserId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
