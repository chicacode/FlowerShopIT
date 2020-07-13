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
        Material material;

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

    }
}
