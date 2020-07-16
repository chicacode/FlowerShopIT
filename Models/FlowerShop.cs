using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
    class FlowerShop
    {
        private string name;
        private List<Product> productsStock;


        public FlowerShop (  )
        {
            
        }

        public FlowerShop ( string _name )
        {
            this.name = _name;
            this.productsStock = new List<Product> ();
        }

        public string NAME
        {
            get => this.name;
            set { this.name = checkFlowerShopName ( value ); }
        }

        private string checkFlowerShopName ( string name )
        {
            while(string.IsNullOrEmpty(name) || name.Length < 2)
            {
                Console.WriteLine ("Introducir un nombre de Floristeria válido");
                return null;
            }

            return this.name = name;
        }

        // Add flower, tree or decoration items into Product List in FlowerShop to get an Stock
        public void addProduct ( Product item )
        {
            this.productsStock.Add ( item );
        }

        // Method to get all the products in stock
        public List<Product> getStockFlowerShop ( )
        {
            return this.productsStock;
        }
    }
}
