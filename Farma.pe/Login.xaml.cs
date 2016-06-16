using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Farma.pe.Resources;

namespace Farma.pe
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            validarUsuario();
        }

        private void validarUsuario()
        {
            NavigationService.Navigate(new Uri("/MenuPrincipal.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnRegistrarte_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegistrarUsuario.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}