using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Newtonsoft.Json;
using Farma.pe.models;
using System.IO.IsolatedStorage;

namespace Farma.pe
{
    public partial class BuscarFarmacias : PhoneApplicationPage
    {
        public BuscarFarmacias()
        {
            InitializeComponent();

            cargarFarmacias();
        }

        private void cargarFarmacias()
        {
            try
            {
                WebClient wc = new WebClient();
                Uri url = new Uri("http://localhost:54973/api/FARMACIA/?id_dis="+30);

                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Listar);
                wc.DownloadStringAsync(url);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Listar(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                List<Farmacia> arr = JsonConvert.DeserializeObject<List<Farmacia>>(e.Result);

                lbFarmacias.ItemsSource = arr;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lbSC(object sender, SelectionChangedEventArgs e)
        {
            if (lbFarmacias.Items.Count > 0) {

                Farmacia farmaciaSeleccionada = lbFarmacias.SelectedItem
                    as Farmacia;

                if (farmaciaSeleccionada != null) {

                    IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;

                    if (!iso.Contains("longitud")&&!iso.Contains("latitud"))
                    {
                        iso.Add("longitud", farmaciaSeleccionada.CORX_FAR);
                        iso.Add("latitud", farmaciaSeleccionada.CORDY_FAR);                    }
                    else
                    {
                        iso["longitud"] = farmaciaSeleccionada.CORX_FAR;
                        iso["latitud"] = farmaciaSeleccionada.CORDY_FAR;
                    }
                    iso.Save();

                    NavigationService.Navigate
                   (new Uri("/MapaFarmacia.xaml", UriKind.RelativeOrAbsolute));
                }
                
            }
        }

    }
}