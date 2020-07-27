using FlowerShopIT.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowerShopIT
{
    /// <summary>
    /// Interaction logic for FlowerShopHome.xaml
    /// </summary>

    public partial class FlowerShopHome : Page
    {
        public FlowerShopHome()
        {
            InitializeComponent();
            DataContext = FlowerShop.GetDetails();
        }

        private void ButtonTree_Click(object sender, RoutedEventArgs e)
        {
            AddTreePage addTreePage = new AddTreePage();
            this.NavigationService.Navigate(addTreePage);
        }

        private void ButtonFlower_Click(object sender, RoutedEventArgs e)
        {
            AddFlowerPage addFlowerPage = new AddFlowerPage();
            this.NavigationService.Navigate(addFlowerPage);
        }

        private void ButtonDeco_Click(object sender, RoutedEventArgs e)
        {
            AddDecorationPage addDecorationPage = new AddDecorationPage();
            this.NavigationService.Navigate(addDecorationPage);
        }

        private void ViewStock_Click(object sender, RoutedEventArgs e)
        {
            StockPage stockPage = new StockPage();
            this.NavigationService.Navigate(stockPage);
        }
    }
}
