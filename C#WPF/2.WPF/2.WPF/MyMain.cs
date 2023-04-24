using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _2.WPF
{
    
    class MyMain : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            MyMain app = new MyMain();
            app.ShutdownMode = ShutdownMode.OnMainWindowClose;
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Main Window
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            mainWindow.Show();

            // Sub Window
            for(int i=0; i<2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i + 1);
                win.Owner = mainWindow;
                win.ShowInTaskbar = false;
                win.Show();
            }
        }

        private void WinMouseDown(object sender, MouseEventArgs args)
        {
            Window win = new Window();
            win.Title = "Modal DioalogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += Button_Click;

            win.Content = b;
            win.ShowDialog();  // Modal 형태

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
