using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace coloresc
{
    public partial class Principal : PhoneApplicationPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void radio(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void check(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/chec.xaml", UriKind.Relative));
        }
    }
}