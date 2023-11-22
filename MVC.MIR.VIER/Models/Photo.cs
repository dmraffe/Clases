using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC.MIR.VIER.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Title { get; set; }
        public byte[] PhotoFile { get; set; }
        public string Description { get; set; }
        public Date TimeCreatedDate { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
