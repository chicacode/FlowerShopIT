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
            InitializeComponent();
        }

        private void ButtonTree_Click ( object sender, RoutedEventArgs e )
        {
            // show texbox and retrieve data
            stack1.Visibility = Visibility;               
        }

        private void ButtonFlower_Click ( object sender, RoutedEventArgs e )
        {
            stack2.Visibility = Visibility;
        }

        private void ButtonDeco_Click ( object sender, RoutedEventArgs e )
        {
            stack3.Visibility = Visibility;
        }

        private void ViewStock_Click ( object sender, RoutedEventArgs e )
        {

        }



        private void AddTree_Click ( object sender, RoutedEventArgs e )
        {
            // Recoge INFO y se crea el OBJETO TREE
        }

        private void AddDeco_Click ( object sender, RoutedEventArgs e )
        {
            // Recoge INFO y se crea el OBJETO DECO
        }

        private void AddFlower_Click ( object sender, RoutedEventArgs e )
        {
            // Recoge INFO y se crea el OBJETO FLOWER
        }
    }
}
