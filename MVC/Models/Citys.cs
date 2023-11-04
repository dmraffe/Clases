namespace MVC.Models
{
    public class Citys
    {
        public string City { get; set; }
        public string Page { get; set; }



        public static List<Citys> getCitys()
        {
            List<Citys> lista = new List<Citys>();

            lista.Add(new Citys
            {
                City = "Buenos AIres",
                Page = "www.gobiernodelaciudad.gov.ar",
            });
            lista.Add(new Citys
            {
                City = "Caracas",
                Page = "www.notiene.com",
            });

            return lista;
        }
    }
}
