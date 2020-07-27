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
    /// Interaction logic for AddTreeWindow.xaml
    /// </summary>
    public partial class AddTreePage : Page
    {
        public AddTreePage()
        {
            InitializeComponent();
            DataContext = FlowerShop.GetDetails();
        }
        static float CheckString(string _string)
        {
            float _float = float.Parse(_string, CultureInfo.InvariantCulture.NumberFormat);
            return _float;
        }

        private void AddTreeMethod(object sender, RoutedEventArgs e)
        {
            float height = CheckString(TreeHeight.Text);
            float price = CheckString(TreePrice.Text);
            Tree newTree = new Tree(price, height);
            DataContext = FlowerShop.AddStock(newTree);
            NavigationService.GoBack();
        }
    }
}
