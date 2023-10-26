using Microsoft.Data.SqlClient;
using MVC.MIR.VIER.Models;
using System.Data;

namespace MVC.MIR.VIER.Implementacion
{
    public class AdmArticulos
    {
        private SqlConnection conexion;
        public string StringConexion = "Data Source=localhost\\SQLEXPRESS;Database=ADO;Trusted_Connection=True;TrustServerCertificate=True;";

        private void Conectar()
        {
            
            conexion = new SqlConnection(StringConexion);
        }

        public int Alta(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert into Articulos( Descripcion, Precio)   values(@descripcion, @precio)", conexion);
          
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters.Add("@precio", SqlDbType.Float);
           
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }


        public List<Articulo> TraerTodos()
        {
            Conectar();
            List<Articulo> articulos = new List<Articulo>();
            SqlCommand sentencia = new SqlCommand("select codigo, descripcion, precio from Articulos",
            conexion);
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();
            while (registros.Read())
            {
                Articulo articulo = new Articulo
                {
                    Codigo = int.Parse(registros["codigo"].ToString()),
                    Descripcion = registros["descripcion"].ToString(),
                    Precio = decimal.Parse(registros["precio"].ToString())
                };
                articulos.Add(articulo);
            }
 
            return articulos;
        }


        public Articulo TraerArticulo(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("select codigo, descripcion, precio     from Articulos where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();
            Articulo articulo = new Articulo();
            if (registros.Read())
            {
                articulo.Codigo = int.Parse(registros["codigo"].ToString());
                articulo.Descripcion = registros["descripcion"].ToString();
                articulo.Precio = decimal.Parse(registros["precio"].ToString());
            }
 
            conexion.Close();
            return articulo;
        }

        public int Modificar(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update Articulos set    descripcion = @descripcion, precio = @precio where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters.Add("@precio", SqlDbType.Float);
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public int Borrar(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("delete from Articulos where codigo=@codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }
    }

   


}

 
 