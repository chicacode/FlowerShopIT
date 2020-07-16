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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            FlowerShop flowerShop1 = new FlowerShop ();
            if(flowerShop1.NAME == null)
            {
                FlowerShopName newFlowerShopName = new FlowerShopName ();
                
                newFlowerShopName.Show ();
            // Cuando haga click en el botón de la ventana principal que aparezca la floristeria con las opciones
                this.DataContext = newFlowerShopName.LabelName;
                
            }
            InitializeComponent ();

        }

        private void ButtonTree_Click ( object sender, RoutedEventArgs e )
        {
            // show new windows and save data
            AddTreeWindow addTree = new AddTreeWindow ();
            addTree.Show ();
                     
        }

        private void ButtonFlower_Click ( object sender, RoutedEventArgs e )
        {
            AddFlowerWindow addFlower = new AddFlowerWindow ();
            addFlower.Show ();
        }

        private void ButtonDeco_Click ( object sender, RoutedEventArgs e )
        {
            AddDecorationWindow addDeco = new AddDecorationWindow ();
            addDeco.Show ();
        }

        private void ViewStock_Click ( object sender, RoutedEventArgs e )
        {
            StockWindow viewStock = new StockWindow ();
            viewStock.Show ();
        }


    }
}
