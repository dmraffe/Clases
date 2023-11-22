using System.ComponentModel.DataAnnotations;
using Validacion.Entity.BasedeDatos;
using Validacion.Entity.Models;

namespace Validacion.Entity.Validadores
{
    public class EmailValidador : ValidationAttribute
    {
       
        public EmailValidador() {
          
        }
        protected override ValidationResult IsValid(object value, ValidationContext  validationContext)
        {
            Persona person = (Persona)validationContext.ObjectInstance;

            var dbcontext = (EntityTestDbContext)validationContext.GetService(typeof(EntityTestDbContext));
            if (dbcontext.Personas.Any(a=>a.EmailAddress == person.EmailAddress  && a.Id != person.Id))
            {
                return new ValidationResult("Email is used");
            }
            return ValidationResult.Success;
        }
    }
}
