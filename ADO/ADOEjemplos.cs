using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public static class ADOEjemplos
    {

      static  SqlCommand SqlCommand;
      static  SqlConnection Conexion;

        public static string StringConexion = "Data Source=localhost\\SQLEXPRESS;Database=ADO;Trusted_Connection=True;TrustServerCertificate=True;";

        public static string Conectar()
        {
            try
            {
                //crear conexion
                Conexion = new SqlConnection(StringConexion);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la configuración de la conexión a la base de datos");
            }
            try
            {
                //abrir conexion
                Conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar conectarse a la base de datos");
            }
 
            try
            {
                //retornar los datos de la conexion
                return "Conectado a: " + Conexion.Database + " usando el string de conexión: " +
                Conexion.ConnectionString;
            }
            catch (Exception e)
            {
                throw new Exception("Error");
            }
            finally
            {
                Conexion.Close();
            }
        }



        public static int ContarProductos()
        {
            try
            {
                //crear conexion
                Conexion = new SqlConnection(StringConexion);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la configuración de la conexión a la base de datos");
            }
            SqlCommand sentencia = new SqlCommand("select count(*) from products", Conexion);
            try
            {
                //abrir conexion
                Conexion.Open();
            }  
            catch (Exception e)
            {
                throw new Exception("Error al intentar conectarse a la base de datos");
            }
            try
            {
                //ejecutar con el metodo escalar
                return Convert.ToInt32(sentencia.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar contar los registros de la tabla");
            }
            finally
            {
                Conexion.Close();
            }
        }


        public static int GuardarEmpleado(Empleado empleado)
        {
            Conexion = new SqlConnection(StringConexion);
            Conexion.Open();
            SqlCommand sentencia = new SqlCommand("insert into employees(firstname, lastname) values(@nombre, @apellido)", Conexion);
            //en storesprocedures necesito agregar commandType
            //sentencia.CommandType = CommandType.StoredProcedure;
            SqlParameter pNombre = new SqlParameter("@nombre", empleado.Nombre);
            SqlParameter pApellido = new SqlParameter("@apellido", empleado.Apellido);
            sentencia.Parameters.Add(pNombre);
            sentencia.Parameters.Add(pApellido);
            return sentencia.ExecuteNonQuery();
        }
       
        public static List<Empleado> ListarEmpleados() {
            Conexion = new SqlConnection(StringConexion);
            Conexion.Open();
            SqlCommand sentencia = new SqlCommand("select EmployeeID, FirstName,  lastname from Employees", Conexion);
            SqlDataReader datareader = null;
            List<Empleado> empleados = new List<Empleado>();
            datareader = sentencia.ExecuteReader(); 
            while (datareader.Read())
            {
                Empleado emp = new Empleado(Convert.ToInt32(datareader[0]), datareader[1].ToString(), datareader[2].ToString());
                empleados.Add(emp);
            }
            return empleados;
        }

        public static List<string> TopTenProductosCaros()
        {
            Conexion = new SqlConnection(StringConexion);
            Conexion.Open();
            SqlCommand sentencia = new SqlCommand("Prueba", Conexion);
            //en storesprocedures necesito agregar commandType
            sentencia.CommandType = CommandType.StoredProcedure;
            SqlDataReader datareader = null;
            List<string> productos = new List<string>();
            datareader = sentencia.ExecuteReader();  
            while (datareader.Read())
            {
                productos.Add("Producto: " + datareader[0].ToString() + " - Precio: " +
                datareader[1].ToString());
            }
            return productos;
        }

    }
}
