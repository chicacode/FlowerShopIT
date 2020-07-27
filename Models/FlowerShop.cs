using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FlowerShopIT.Models
{
    public class FlowerShop
    {
      
        public ObservableCollection<IProduct> Stock { get; set; }
        public ObservableCollection<string> FlowerStock { get; set; }
        public ObservableCollection<string> TreeStock { get; set; }
        public ObservableCollection<string> DecorationStock { get; set; }

        static FlowerShop _flowerShop;
        private string name;
        public FlowerShop ( ) { }
        public FlowerShop ( string name )
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = checkName ( value ); }
        }

        private string checkName ( string name )
        {
            while(string.IsNullOrEmpty ( name ) || name.Length < 3)
            {
                throw new ArgumentException ( "Flower Shop cannot be empty" );
            }
            return name;
        }
        public static FlowerShop GetDetails()
        {
            if (_flowerShop == null)
                _flowerShop = new FlowerShop();

            return _flowerShop;
        }
        public static FlowerShop AddStock(IProduct product)
        {
            if (_flowerShop.Stock == null)
                _flowerShop.Stock = new ObservableCollection<IProduct>();

            _flowerShop.Stock.Add(product);
            return _flowerShop;
        }

        // https://stackoverflow.com/a/15341181
        public static bool HasProperty(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName) != null;
        }

        public static FlowerShop GenerateProductStocks()
        {
            if (_flowerShop.Stock == null)
                _flowerShop.Stock = new ObservableCollection<IProduct>();

            _flowerShop.FlowerStock = new ObservableCollection<string>();
            _flowerShop.TreeStock = new ObservableCollection<string>();
            _flowerShop.DecorationStock = new ObservableCollection<string>();

            foreach (IProduct product in _flowerShop.Stock)
            {
                if (product.GetType().GetProperty("Color") != null)
                {                    
                    _flowerShop.FlowerStock.Add($"Color: {((Flower)product).Color}, Price: {product.Price.ToString("C", CultureInfo.CurrentCulture)}");
                }
                else if (product.GetType().GetProperty("Height") != null)
                {                    
                    _flowerShop.TreeStock.Add($"Height: {((Tree)product).Height:n2}, Price: {product.Price.ToString("C", CultureInfo.CurrentCulture)}");
                }
                else
                {
                    _flowerShop.DecorationStock.Add($"Material: {((Decoration)product).Material}, Price: {product.Price.ToString("C", CultureInfo.CurrentCulture)}");
                }
            }

            if (!_flowerShop.FlowerStock.Any())
                _flowerShop.FlowerStock.Add($"{_flowerShop.Name} has no flowers yet!");
            if (!_flowerShop.TreeStock.Any())
                _flowerShop.TreeStock.Add($"{_flowerShop.Name} has no trees yet!");
            if (!_flowerShop.DecorationStock.Any())
                _flowerShop.DecorationStock.Add($"{_flowerShop.Name} has no decorations yet!");

            return _flowerShop;
        }
    }
}
