﻿using System;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// ch9.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ch9 : Window
    {
        public ch9()
        {
            InitializeComponent();
        }

        private void cb3_Checked(object sender, RoutedEventArgs e)
        {
            txt.Background = Brushes.Salmon;
        }

        private void cb3_Unchecked(object sender, RoutedEventArgs e)
        {
            txt.Background = Brushes.White;
        }

        private void cbAll_Checked(object sender, RoutedEventArgs e)
        {
            cb1.IsChecked = cbAll.IsChecked;
            cb2.IsChecked = cbAll.IsChecked;
            cb3.IsChecked = cbAll.IsChecked;
            cb4.IsChecked = cbAll.IsChecked;
        }

        private void cbAll_Unchecked(object sender, RoutedEventArgs e)
        {
            cb1.IsChecked = cbAll.IsChecked;
            cb2.IsChecked = cbAll.IsChecked;
            cb3.IsChecked = cbAll.IsChecked;
            cb4.IsChecked = cbAll.IsChecked;
        }
    }
}
