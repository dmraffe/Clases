namespace MVC.Models
{
    public class SimpleModel
    {
        public string Value { get; set; }  

        public List<string> Codigos { get; set; } = new List<string>();

        public string Mensaje { get; set; }

        public SimpleModel() {

            Codigos.Add("AS114");
            Codigos.Add("AS117");
            Codigos.Add("AS118");
            Codigos.Add("AS119");

            Mensaje = "Real madrid esta perdiendo";
        }
    }
}
