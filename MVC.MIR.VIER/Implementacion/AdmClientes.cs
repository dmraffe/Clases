using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using MVC.MIR.VIER.Models;

namespace MVC.MIR.VIER.Implementacion
{
    public class AdmClientes
    {
        private SqlConnection conexion;
        public string StringConexion = "Data Source=localhost\\SQLEXPRESS;Database=ADO;Trusted_Connection=True;TrustServerCertificate=True;";

        private void Conectar()
        {

            conexion = new SqlConnection(StringConexion);
        }


        public int Alta(Clientes pCliente)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert into Clientes(Nombre, Apellido, Email)    values(@nombre, @apellido, @email)", conexion);
            sentencia.Parameters.Add("@nombre", SqlDbType.VarChar);
            sentencia.Parameters.Add("@apellido", SqlDbType.VarChar);
            sentencia.Parameters.Add("@email", SqlDbType.VarChar);
            sentencia.Parameters["@nombre"].Value = pCliente.Nombre;
            sentencia.Parameters["@apellido"].Value = pCliente.Apellido;
            sentencia.Parameters["@email"].Value = pCliente.Email;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public List<Clientes> TraerTodos()
        {
            Conectar();
            List<Clientes> clientes = new List<Clientes>();
            SqlCommand sentencia = new SqlCommand("select codigo, nombre, apellido, email from  clientes", conexion);
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();
            while (registros.Read())
            {
                Clientes cliente = new Clientes
                {
                    Codigo = int.Parse(registros["codigo"].ToString()),
                    Nombre = registros["nombre"].ToString(),
                    Apellido = registros["apellido"].ToString(),
                    Email = registros["email"].ToString()
                };
                clientes.Add(cliente);
            }

            conexion.Close();
            return clientes;
        }
        public Clientes TraerCliente(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("select codigo, nombre, apellido, email from       clientes where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            conexion.Open();
            SqlDataReader registros = sentencia.ExecuteReader();
            Clientes cliente = new Clientes();
            if (registros.Read())
            {
                cliente.Codigo = int.Parse(registros["codigo"].ToString());
                cliente.Nombre = registros["nombre"].ToString();
                cliente.Apellido = registros["apellido"].ToString();
                cliente.Email = registros["email"].ToString();
            }

            conexion.Close();
            return cliente;
        }
        public int Modificar(Clientes pCliente)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update clientes set nombre = @nombre, apellido = @apellido, email = @email where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@nombre", SqlDbType.VarChar);
            sentencia.Parameters.Add("@apellido", SqlDbType.VarChar);
            sentencia.Parameters.Add("@email", SqlDbType.VarChar);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCliente.Codigo;
            sentencia.Parameters["@nombre"].Value = pCliente.Nombre;
            sentencia.Parameters["@apellido"].Value = pCliente.Apellido;
            sentencia.Parameters["@email"].Value = pCliente.Email;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }

        public int Borrar(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("delete from clientes where codigo=@codigo",  conexion);
            sentencia.Parameters.Add("@codigo", SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;
            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }
    }
}
 
