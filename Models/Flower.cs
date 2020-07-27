using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
   public class Flower : IProduct
    {
        public string Color { get; set; }
        public float Price { get; set; }

        public Flower (float _price, string _color)
        {
            Price = _price;
            Color = _color;
        }
    }
}
