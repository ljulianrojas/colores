using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using coloresc.Resources;
using System.Windows.Media;

namespace coloresc
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void cambiarColor(object sender, RoutedEventArgs e)
        {
            SolidColorBrush micorlor = new SolidColorBrush();
            micorlor.Color = Colors.Purple; 
            if (rbtn_Amamarillo.IsChecked == true)
            {
                micorlor.Color = Colors.Yellow; 
            }
            if (rbtn_Azul.IsChecked == true)
            {
                micorlor.Color = Colors.Blue;
            }
            if (rbtn_Rojo.IsChecked == true)
            {
                micorlor.Color = Colors.Red;
            }
            this.rectangulo.Fill = micorlor;
            
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}