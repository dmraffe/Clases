using AutoFixture;
using EjemploTests;
using Microsoft.EntityFrameworkCore;
using Modulos.Avanzado.Sabados.Dominio;
using Modulos.Avanzado.Sabados.Repositorio;
using Modulos.Avanzado.Sabados.Servicios;
using Modulos.Avanzados.Sabados.DB;

namespace Modulos.Avanzado.Test
{
    [TestClass]
    public class Testbasico
    {




        [TestMethod]
        public void  TestUno()
        {

            int numerouno = 9;
            int numerodos = 10;
            var ejemplo =  new PruebasdeMetodos();

            var resul = ejemplo.NumeroMayor(numerouno, numerodos);
            Assert.AreEqual(10, resul);
        }


        [TestMethod]
        public async Task AddClienteTest()
        {
           var options = new DbContextOptionsBuilder<ModulosAvanzadoDBContext>()
                .UseInMemoryDatabase(databaseName: $"PruebasSabnados-{Guid.NewGuid()}")
                .Options;
            
            IAsyncBaseRepositorio<Cliente> asyncBaseRepositorio = new BaseRepositorio<Cliente>(new ModulosAvanzadoDBContext(options));
            ServicioCLiente servicioCLiente = new ServicioCLiente(asyncBaseRepositorio);

            var fx = new Fixture();
            fx.Behaviors.Add(new OmitOnRecursionBehavior());
            var listacliente = fx.CreateMany<Cliente>().ToList();

            listacliente.Add(listacliente[0]);



            try
            {
                foreach (var item in listacliente)
                {
                    var r = await servicioCLiente.AddCliente(item);
                    Assert.AreEqual(r, true);
                }

            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("El correo ya existe", ex.Message);
            }

            catch (NullReferenceException ex)
            {
                Assert.AreEqual("El correo ya existe", ex.Message);
            }
            catch (ClienteExcepcion ex)
            {
                Assert.AreEqual("El correo ya existe", ex.Message);
            }
                  
                   
             

        }
    }
}