using System.ComponentModel.DataAnnotations;
using Validacion.Entity.Validadores;

namespace Validacion.Entity.Models
{
    public class Persona
    {

        public int Id { get; set; }

        [Display(Name = "MyName")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Range(0, 150,ErrorMessage ="age out of range ")]
        public int Age { get; set; }
        [Required]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please insert a valid email")]
        [EmailValidador]
        public string EmailAddress { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(20,ErrorMessage ="Error")]
        [Required(ErrorMessage ="Is Mandatory")]
        
        public string Description { get; set; }

        [Display(Name = "last Name")]
        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }


    }
}
