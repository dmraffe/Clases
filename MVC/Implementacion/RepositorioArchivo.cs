using Microsoft.Extensions.Hosting.Internal;
using MVC.Contratos;
using MVC.Models;

namespace MVC.Implementacion
{
    public class RepositorioArchivo : IRepositorioArchivo
    {
        public void GuardarDatos(Comentario comentario)
        {
            StreamWriter streamWriter = new StreamWriter($"{Directory.GetCurrentDirectory()}/file/datos.cvs",true);
            streamWriter.WriteLine($"{comentario.Id},{comentario.Nombre},{comentario.Comentarios}");
            streamWriter.Close();

        }

        public IEnumerable<Comentario> ObtenerComentario()
        {



              List<Comentario> lista = new List<Comentario>();

            try
            {
                StreamReader streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}/file/datos.cvs");
                var data = streamReader.ReadToEnd();

                var datalis = data.Split("\r\n");

                foreach (var d in datalis)
                {
                    var details = d.Split(",");
                    lista.Add(new Comentario
                    {
                        Id = details[0],
                        Nombre = details[1],
                        Comentarios = details[2]

                    });

                }

                streamReader.Close();
            }
            catch (Exception ex) { 
            
            }
            return lista;
        }

        public Comentario ObtenerComentarioPorId(string Id)
        {
            var lista = ObtenerComentario();
            var comentario = lista.Where(a=>a.Id == Id).FirstOrDefault();
            return comentario;
        }
    }
}
