using FlowerShopIT.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddDecorationWindow.xaml
    /// </summary>
    public partial class AddDecorationPage : Page
    {
        public AddDecorationPage()
        {
            InitializeComponent();
            DataContext = FlowerShop.GetDetails();
        }

        static float CheckString(string _string)
        {
            float _float = float.Parse(_string, CultureInfo.InvariantCulture.NumberFormat);
            return _float;
        }
        private void NumberValidationTextBox ( object sender, TextCompositionEventArgs e )
        {
            Regex regex = new Regex ( "[^0-9]+" );
            e.Handled = regex.IsMatch ( e.Text );
        }
        private void AddDecorationMethod(object sender, RoutedEventArgs e)
        {
            string material = DecorationMaterial.Text;
            float price = CheckString(DecorationPrice.Text);
            Decoration newDecoration = new Decoration(price, material);
            DataContext = FlowerShop.AddStock(newDecoration);
            NavigationService.GoBack();
        }
    }
}
