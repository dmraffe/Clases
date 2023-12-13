using EntityAvansado.Repositorio.Implementacion;
using EntityAvansado.Repositorio.Interfaces;
using EntityAvanzado;
using EntityAvanzado.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace TestMiercoles
{
    [TestClass]
    public class UnitTest1
    {
           IRepositorioCliente cliente;
            EntityAvanzadoDBContext dbContext;

        public UnitTest1()
        {
            var options = new DbContextOptionsBuilder<EntityAvanzadoDBContext>()
             .UseInMemoryDatabase(databaseName: $"PruebasMiercoles-{Guid.NewGuid()}")
             .Options;


            this.dbContext = new EntityAvanzadoDBContext(options);

            this.cliente = new RepositorioCliente(dbContext);
           
        }

        [TestMethod]
        public void TestMethod1()
        {
             Product  pr = new Product("Pedro", 2, 300);


      
            Assert.AreEqual(pr.GetPriceWithTax(10),330);
        }


        [TestMethod]
        public async Task AddCLiente()
        {
            var result = await this.cliente.AddCliente(new EntityAvanzado.Modelos.DBModel.Cliente
            {

                Apellido = "",
                Nombre = "asdasd",
                Correo = "dixon@asas.com",
                Passsword ="asdasd"                
            });


            await Assert.ThrowsExceptionAsync<ClienteException>(
                 () => cliente.AddCliente(

                     new EntityAvanzado.Modelos.DBModel.Cliente
                     {

                         Apellido = "",
                         Nombre = "asdasd",
                         Correo = "dixon@asas.com",
                         Passsword = "asdasd"
                     })
                     );
            try
            {
                  await this.cliente.AddCliente(new EntityAvanzado.Modelos.DBModel.Cliente
                {

                    Apellido = "",
                    Nombre = "",
                    Correo = "dixon@asas.com",
                    Passsword = "asdasd"
                });

            } catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "EL nombre no puede estar vacio");
            }



            await Assert.ThrowsExceptionAsync<Exception>(
                    () => cliente.AddCliente(

                        new EntityAvanzado.Modelos.DBModel.Cliente
                        {

                            Apellido = "",
                            Nombre = "",
                            Correo = "dixon@asas.com",
                            Passsword = "asdasd"
                        })
                        );


        }



        [TestMethod]
        public async Task AddCLienteDos()
        {
            try
            {
                var result = await this.cliente.AddCliente(new EntityAvanzado.Modelos.DBModel.Cliente
                {

                    Apellido = "",
                    Nombre = "asdasd",
                    Correo = "dixon@asas.com",
                    Passsword = "asdasd"
                });

            }
            catch (ClienteException ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "EL Apellido no puede estar vacio");
            }

            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }

            try
            {
                var result = await this.cliente.AddCliente(new EntityAvanzado.Modelos.DBModel.Cliente
                {

                    Apellido = "asdasd",
                    Nombre = "",
                    Correo = "dixon@asas.com",
                    Passsword = "asdasd"
                });
            } catch (ClienteException ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }

            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "EL nombre no puede estar vacio");
            }


            try {  

            await cliente.AddCliente(new EntityAvanzado.Modelos.DBModel.Cliente
                {

                    Apellido = "asdasd",
                    Nombre = "asdasd",
                    Correo = "dixon@asas.com",
                    Passsword = "asdasd"
                });


                await cliente.AddCliente(new EntityAvanzado.Modelos.DBModel.Cliente
                {

                    Apellido = "asdasd",
                    Nombre = "asdasd",
                    Correo = "dixon@asas.com",
                    Passsword = "asdasd"
                });
            }
            catch (ClienteException ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }

            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "El correo ya existe");
            }
        }
     }
}