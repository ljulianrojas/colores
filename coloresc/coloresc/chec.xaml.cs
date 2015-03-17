using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace coloresc
{
    public partial class chec : PhoneApplicationPage
    {
        public chec()
        {
            InitializeComponent();
        }

        private void cambiarColor(object sender, RoutedEventArgs e)
        {
            SolidColorBrush micolor = new SolidColorBrush();
            if (rbtn_Amamarillo.IsChecked == true && rbtn_Azul.IsChecked == false && rbtn_Rojo.IsChecked == false)
            {
                micolor.Color = Colors.Yellow;

            }
            else if (rbtn_Amamarillo.IsChecked == false && rbtn_Azul.IsChecked == true && rbtn_Rojo.IsChecked == false)
            {
                micolor.Color = Colors.Blue;
            
            }
            else if (rbtn_Amamarillo.IsChecked == false && rbtn_Azul.IsChecked == false && rbtn_Rojo.IsChecked == true) {

                micolor.Color = Colors.Red;
            }
            else if (rbtn_Amamarillo.IsChecked == true && rbtn_Azul.IsChecked == true && rbtn_Rojo.IsChecked == false) {
                micolor.Color = Colors.Green;
            }
            else if (rbtn_Amamarillo.IsChecked == true && rbtn_Azul.IsChecked == false && rbtn_Rojo.IsChecked == true) {
                micolor.Color = Colors.Orange;
            }
            else if (rbtn_Amamarillo.IsChecked == false && rbtn_Azul.IsChecked == true && rbtn_Rojo.IsChecked == true) {

                micolor.Color = Colors.Purple;
            }
            else if (rbtn_Amamarillo.IsChecked == true && rbtn_Azul.IsChecked == true && rbtn_Rojo.IsChecked == true)
            {
                micolor.Color = Colors.Black;
            }
            else {
                micolor.Color = Colors.White;
            
            }
            this.rectangulo.Fill = micolor;
        }
    }
}