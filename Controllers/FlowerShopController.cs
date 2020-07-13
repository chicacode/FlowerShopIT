using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FlowerShopIT.Models;

namespace FlowerShopIT.Controllers
{
    // class controller where make all the operations
    class FlowerShopController
    {
        // Constructor
        public FlowerShopController ( ) { }

        // create the methods to add each element in the product List with its own parameters
        public void addFlower ( FlowerShop flowerShop, double price, string color )
        {
            Flower rose = new Flower ( price, color );
            flowerShop.addProduct ( rose );
        }

        public void addTree ( FlowerShop flowerShop, double price, double height )
        {
            Tree tree = new Tree ( price, height );
            flowerShop.addProduct ( tree );
        }

        public void addDecoration ( FlowerShop flowershop, double price, Material type )
        {
            Decoration decoration = new Decoration ( price, type );
            flowershop.addProduct ( decoration );
        }
    }
}
