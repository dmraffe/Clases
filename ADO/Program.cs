using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(  ADOEjemplos.Conectar());
           Console.WriteLine(ADOEjemplos.ContarProductos());
            Console.WriteLine(ADOEjemplos.GuardarEmpleado(new Empleado{ 
              Apellido ="Raffe",
              Nombre = "Miguel"
            }));

            Console.WriteLine(ADOEjemplos.GuardarEmpleado(new Empleado
            {
                Apellido = "Cortes",
                Nombre = "Scarlet"
            }));

            Console.WriteLine(ADOEjemplos.GuardarEmpleado(new Empleado
            {
                Apellido = "Sanchez",
                Nombre = "Andres"
            }));

            Console.WriteLine(ADOEjemplos.GuardarEmpleado(new Empleado
            {
                Apellido = "Lopez",
                Nombre = "Andres"
            }));

            var lista = ADOEjemplos.ListarEmpleados();

            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre : {item.Nombre} Apellido: {item.Apellido}");
            }


            var Listaproducto = ADOEjemplos.TopTenProductosCaros();

            foreach (var item in Listaproducto)
            {
                Console.WriteLine($"{item}");
            }

            Console.Read();
        }




    }
}
