using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
    public class Decoration : IProduct
    {
        // USer attribute Material type
        public string Material { get; set; }
        public float Price { get; set; }

        // Constructor
        public Decoration (float _price, string _material)
        {
            Price = _price;
            Material = _material;
        }

        /*
        public Material materialPlastic ( )
        {
            Material plastic = Material.PLASTIC;
            return plastic;
        }

        public Material materialWood ( )
        {
            Material wood = Material.WOOD;
            return wood;
        } */
    }
}
