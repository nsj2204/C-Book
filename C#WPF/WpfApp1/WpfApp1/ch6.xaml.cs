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
    /// ch6.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ch6 : Window
    {
        public ch6()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("클릭");
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("더블클릭");
        }
    }
}
