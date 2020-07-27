using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
    public class Tree : IProduct
    {
        public float Height { get; set; }
        public float Price { get; set; } 

        public Tree (float _price, float _height)
        {
            Price = _price;
            Height = _height;
        }
    }
}
