using Modulos.Avanzado.Sabados.Dominio;

namespace Modulos.Avanzado.Sabados.Models
{
    public class DireccionesDTI
    {
        public DireccionesDTI( )
        {
            
        }

        public DireccionesDTI(IEnumerable<Pais> pais)
        {
            Pais = pais;
        }

        public string Calle { get; set; }

        public int NumerodeCalle { get; set; }

        public string Provincia { get; set; }

       

        public string? Apartamento { get; set; }

        public int ClienteId { get; set; }

        public int CiudadId { get; set; }

        public IEnumerable<Pais> Pais { get; set; }

    }
}
