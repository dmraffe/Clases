using MVC.Models;

namespace MVC.Contratos
{
    public interface IRepositorioArchivo
    {
        void GuardarDatos(Comentario comentario);

        IEnumerable<Comentario>ObtenerComentario();


         Comentario ObtenerComentarioPorId(string Id);

    }
}
