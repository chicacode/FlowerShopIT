﻿using System;
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

namespace FlowerShopIT
{
    /// <summary>
    /// Interaction logic for FlowerShopName.xaml
    /// </summary>
    public partial class FlowerShopName : Window, INotifyPropertyChanged
    {
        private string name, labelName;
        public FlowerShopName()
        {
            InitializeComponent();
        }
        //public FlowerShopName ( string name )
        //{
        //    this.name = name;
        //}
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged ( string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged ( this, new PropertyChangedEventArgs ( property ) );
            }
         
        }
        public string NAME {
            get => this.name;
            set { name = value; OnPropertyChanged ( "LabelName" ); }
        }

        public string LabelName
        {
            get { labelName = NAME; return labelName; }
            set { labelName = value;  }
          
        }
    }
}
