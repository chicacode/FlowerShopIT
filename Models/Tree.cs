using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
    class Tree : Product
    {
       private double height;

        public Tree ( double _price, double _height )
        {
            PRICE = _price;
            this.height = _height;
        }

        public double getHeight ( )
        {
            return height;
        }

    }
}
