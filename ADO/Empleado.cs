using System.Data;

public class Empleado
{
    

    
    public int ID { get; set; }
    public string Nombre { get;  set; }
    public string Apellido { get;  set; }

    public Empleado()
    {
       
    }
    public Empleado(int iD, string nombre, string apellido)
    {
        ID = iD;
        Nombre = nombre;
        Apellido = apellido;
    }
}