namespace Clase1PPO
{
    public class Persona
    {
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}