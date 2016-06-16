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

using Newtonsoft.Json;
using Farma.pe.models;

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
            //  validarUsuario();
            NavigationService.Navigate(new Uri("/MenuPrincipal.xaml", UriKind.RelativeOrAbsolute));
        }

        private void validarUsuario()
        {
            if (txtUsuario.Text == String.Empty || txtContrasena.Text == String.Empty)
            {
                MessageBox.Show("Falta el usuario o contraseña");
            }
            else
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54973/api/USUARIO");

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Buscar);
                wc.DownloadStringAsync(url);
            }
        }

        private void Buscar(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(e.Result);

                foreach (Usuario usuario in usuarios)
                {
                    if (txtUsuario.Text == usuario.NOM_USU && txtContrasena.Text == usuario.PASS_USU)
                    {
                        NavigationService.Navigate(new Uri("/MenuPrincipal.xaml", UriKind.RelativeOrAbsolute));
                    }
                }
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarte_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegistrarUsuario.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}