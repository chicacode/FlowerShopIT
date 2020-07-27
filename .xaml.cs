using FlowerShopIT.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlowerShopIT
{
    /// <summary>
    /// Interaction logic for AddFlowerWindow.xaml
    /// </summary>
    public partial class AddFlowerPage : Page
    {
        public AddFlowerPage()
        {
            InitializeComponent();
        }

        static float CheckString(string _string)
        {
            float _float = float.Parse(_string, CultureInfo.InvariantCulture.NumberFormat);
            return _float;
        }

        private void AddFlowerMethod(object sender, RoutedEventArgs e)
        {
            string color = FlowerColor.Text;
            float price = CheckString(FlowerPrice.Text);
            Flower newFlower = new Flower(price, color);
            DataContext = FlowerShop.AddStock(newFlower);
            NavigationService.GoBack();
        }
    }
}
