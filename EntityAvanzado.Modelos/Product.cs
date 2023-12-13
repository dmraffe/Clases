using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAvanzado.Modelos
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public float BasePrice { get; set; }

        public Product(string name, int id, float basePrice)
        {
            Name = name;
            Id = id;
            BasePrice = basePrice;
        }

        public float GetPriceWithTax(float taxPercent)
        {
            return BasePrice + (BasePrice * (taxPercent / 100));
        }
    }
}
