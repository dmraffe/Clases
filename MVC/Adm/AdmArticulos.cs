using System.Data;
using System.Data.SqlClient;

namespace MVC.Adm
{
    public class AdmArticulos
    {
        private SqlConnection conexion;
        private IConfiguration _configuration;

        public AdmArticulos(IConfiguration configuration)
        {
          _configuration = configuration;
        }
        private void Conectar()
        {
          
           string stringConexion = _configuration.GetConnectionString("AdoWeb");
            conexion = new SqlConnection(stringConexion);
            conexion.Open();
        }


        public int Alta(Models.Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert into Articulos(Descripcion, Precio)  values (@descripcion, @precio)", conexion);           
      
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters.Add("@precio", SqlDbType.Float);
            
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;
          
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }


        public List<Models.Articulo> TraerTodos()
        {
            Conectar();
            List<Models.Articulo> articulos = new List<Models.Articulo>();
            SqlCommand sentencia = new SqlCommand("select codigo, descripcion, precio from articulos", conexion);
           
            SqlDataReader registros = sentencia.ExecuteReader();
            while (registros.Read())
            {
                var  articulo = new Models.Articulo
                {
                    Codigo = int.Parse(registros["codigo"].ToString()),
                    Descripcion = registros["descripcion"].ToString(),
                    Precio = decimal.Parse(registros["precio"].ToString())
                };
                articulos.Add(articulo);
            }
 
            return articulos;
        }
        public Models.Articulo TraerArticulo(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("select codigo, descripcion, precio   from articulos where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            
            SqlDataReader registros = sentencia.ExecuteReader();
            var articulo = new Models.Articulo();
            if (registros.Read())
            {
                articulo.Codigo = int.Parse(registros["codigo"].ToString());
                articulo.Descripcion = registros["descripcion"].ToString();
                articulo.Precio = decimal.Parse(registros["precio"].ToString());
            }
 
            conexion.Close();
            return articulo;
        }

        public int Modificar(Models.Articulo pArticulo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update articulos set  descripcion = @descripcion, precio = @precio where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@descripcion", SqlDbType.VarChar);
            sentencia.Parameters["@descripcion"].Value = pArticulo.Descripcion;
            sentencia.Parameters.Add("@precio", SqlDbType.Float);
            sentencia.Parameters["@precio"].Value = pArticulo.Precio;
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pArticulo.Codigo;
            
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public int Borrar(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("delete from articulos where codigo=@codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }


    }
}
