using MVC.MIR.VIER.Controllers;
using MVC.MIR.VIER.Models;

namespace MVC.MIR.VIER.Contratos
{
    public interface IAdministradorArchivo
    {
        void GuardarDatosenelArchivo(Visita visitas);

        List<Visita>  ObtenerVisitas();
        
    }
}
