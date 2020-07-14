using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
    class Decoration : Product
    {
        // USer attribute Material type
        private Material material;

        // Constructor
        public Decoration ( double _price, Material _material )
        {
            this.PRICE = _price;
            this.material = _material;
        }

        public Material getMaterial ( )
        {
            return this.material;
        }

        public void setMaterial ( Material _material )
        {
            this.material = _material;
        }

        //public override string ToString ( )
        //{
        //    string materialFound;
        //    if(material.Equals ( "PLASTIC" ))
        //    {
        //        materialFound = "PLASTIC";
        //    }
        //    else
        //    {
        //        materialFound = "WOOD";
        //    }
        //    return materialFound;
        //}

        public Material materialPlastic ( )
        {
            Material plastic = Material.PLASTIC;
            return plastic;
        }

        public Material materialWood ( )
        {
            Material wood = Material.WOOD;
            return wood;
        }
    }
}
