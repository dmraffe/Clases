using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADO.MIER.VIER
{
    public static class ADO
    {

        public static string StringConexion = "Data Source=localhost\\SQLEXPRESS;Database=ADO;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection Conexion = null;
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
            SqlCommand sentencia = new SqlCommand("select count(*) from products where Precio >= 100", Conexion);
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

    }
}

