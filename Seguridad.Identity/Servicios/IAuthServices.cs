namespace Seguridad.Identity.Servicios
{
    public interface IAuthServices
    {
        public Task<bool> Login(string username, string password);

        public Task<bool> Register(RegistrationRequest registration);


    }
}
