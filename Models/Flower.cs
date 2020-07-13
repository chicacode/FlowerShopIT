using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
   public class Flower : Product
    {
        // attribute
        private string colorFlower;

        // Constructor
        public Flower ( double _price, string _color)
        {
            this.PRICE = _price;
            this.colorFlower = _color;
        }

        // Method
        public string getColor ( )
        {
            return this.colorFlower;
        }
    }
}
