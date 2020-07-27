using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using FlowerShopIT.Models;

namespace FlowerShopIT
{
    /// <summary>
    /// Interaction logic for FlowerShopName.xaml
    /// </summary>
    public partial class FlowerShopName : Window
    {
        public FlowerShopName()
        {
            InitializeComponent();
            DataContext = FlowerShop.GetDetails();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
