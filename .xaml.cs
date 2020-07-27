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
        private void validateTextCharacter ( object sender, EventArgs e )
        {
            TextBox T = (TextBox)sender;
            try
            {
                //Not Allowing Numbers
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if(textContainsUnallowedCharacter ( T.Text, UnallowedCharacters ))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove ( CursorIndex, 1 );

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch(Exception) { }
        }
        private bool textContainsUnallowedCharacter ( string T, char[] UnallowedCharacters )
        {
            for(int i = 0; i < UnallowedCharacters.Length; i++)
                if(T.Contains ( UnallowedCharacters[i] ))
                    return true;

            return false;
        }
        private string checkColorName ( string name )
        {
            while(string.IsNullOrEmpty ( name ) )
            {
                throw new ArgumentException ( "Flower Shop cannot be empty" );
            }
            return name;
        }
        private void NumberValidationTextBox ( object sender, TextCompositionEventArgs e )
        {
            Regex regex = new Regex ( @"^[0-9]*(?:\.[0-9]*)?$" );
            if(regex.IsMatch ( e.Text ) && !(e.Text == "." && ((TextBox)sender).Text.Contains ( e.Text )))
                e.Handled = false;

            else
                e.Handled = true;

        }
        private void AddFlowerMethod(object sender, RoutedEventArgs e)
        {
            string color = checkColorName(FlowerColor.Text);
            float price = CheckString(FlowerPrice.Text);
            Flower newFlower = new Flower(price, color);
            DataContext = FlowerShop.AddStock(newFlower);
            NavigationService.GoBack();
        }
    }
}
