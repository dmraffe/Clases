using MVC.MIR.VIER.Contratos;
using MVC.MIR.VIER.Models;

namespace MVC.MIR.VIER.Implementacion
{
    public class AdministradorArchivo : IAdministradorArchivo
    {
      
        public AdministradorArchivo( )
        {
     

        }

        public void GuardarDatosenelArchivo(Visita visitas)
        {
            StreamWriter streamWriter = new StreamWriter($"{Directory.GetCurrentDirectory()}/file/datos.cvs", true);
            streamWriter.WriteLine($"{visitas.Id},{visitas.Nombre},{visitas.Comentario}");
            streamWriter.Close();
        }

        public List<Visita> ObtenerVisitas()
        {

            List<Visita> lista = new List<Visita>();

            try
            {
                StreamReader streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}/file/datos.cvs");
                var data = streamReader.ReadToEnd();

                var datalis = data.Split("\r\n");

                foreach (var d in datalis)
                {
                    var details = d.Split(",");
                    lista.Add(new Visita
                    {
                        Id = details[0],
                        Nombre = details[1],
                        Comentario = details[2]

                    });

                }

                streamReader.Close();
            }
            catch (Exception ex)
            {

            }
            return lista;
        }
    }
}
