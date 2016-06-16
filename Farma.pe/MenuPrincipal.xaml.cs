using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Farma.pe
{
    public partial class MenuPrincipal : PhoneApplicationPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMedicamentos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BuscarMedicamentos.xaml", UriKind.RelativeOrAbsolute));

        }

        private void btnFarmacias_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BuscarFarmacias.xaml", UriKind.RelativeOrAbsolute));

        }

        private void btnFrecuentes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/VerFrecuentes.xaml", UriKind.RelativeOrAbsolute));

        }

        private void btnPromociones_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/VerPromociones.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}