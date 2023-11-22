using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Person
    {

        [Display(Name = "MyName")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a password.")]
        [MinLength(6,ErrorMessage ="Password be must a 6 Digits")]

        public string Password { get; set; }
        
        
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a Birthdate.")]
        public DateTime Birthdate{ get; set; }


         [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter a Email Addres.")]
        [RegularExpression(".+\\@.+\\..+")]

        public string EmailAddress { get; set; }
   
        [DataType(DataType.MultilineText)]
        [StringLength(20)]

        [Required (ErrorMessage = "Please enter a Description") ]
        public string Description { get; set; }

        [Display(Name = "Contactarme ?")]
        public bool? ContactMe { get; set; } = false;


    }
}
