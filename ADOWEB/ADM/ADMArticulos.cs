
using ADOWEB.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Primitives;
using System.Data;

namespace ADOWEB.ADM
{
    public class ADMArticulos
    {
        private  SqlConnection conexion;
        private string stringConexion;

        public ADMArticulos(string _conexion)
        {
            this.stringConexion = _conexion;
        }


        private void Conectar()
        {

            conexion = new SqlConnection(stringConexion);
        }
        public int Alta(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert into Articulos(Codigo, Descripcion, Precio) values(@codigo, @descripcion, @precio)", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters.Add("@precio", SqlDbType.Float);
            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;
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
            SqlCommand sentencia = new SqlCommand("select codigo, descripcion, precio from articulos",  conexion);
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

            conexion.Close();
            return articulos;
        }


        public int Modificar(Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update articulos set  descripcion = @descripcion, precio = @precio wherecodigo = @codigo", conexion);
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
            SqlCommand sentencia = new SqlCommand("delete from articulo swhere codigo=@codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }




    }
}
