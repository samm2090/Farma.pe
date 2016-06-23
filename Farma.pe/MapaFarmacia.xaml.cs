using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using System.IO.IsolatedStorage;
using System.Device.Location;
using Windows.Devices.Geolocation;
using Microsoft.Phone.Maps.Toolkit;
using Farma.pe.models;

namespace Farma.pe
{
    public partial class MapaFarmacia : PhoneApplicationPage
    {
        public MapaFarmacia()
        {
            InitializeComponent();

            //Microsoft.Phone.Maps.MapsSettings.ApplicationContext.ApplicationId = "ApplicationID";
            //Microsoft.Phone.Maps.MapsSettings.ApplicationContext.AuthenticationToken = "AuthenticationToken";

            IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;

            if (iso.Contains("longitud")&&iso.Contains("latitud"))
            {
                Double longitud = Double.Parse(iso["longitud"].ToString());
                Double latitud = Double.Parse(iso["latitud"].ToString());

                mapaFarmacia.Center = new GeoCoordinate(longitud,latitud);
                mapaFarmacia.ZoomLevel = 16;
            }
            else
            {
                
            }

        }

        //async void CargarMapa(object sender, RoutedEventArgs e)
        //{
        //    Geolocator locator = new Geolocator();
        //    Geoposition geoPosition = await locator.GetGeopositionAsync();
        //   // GeoCoordinate coordinate = geoPosition.Coordinate.ToGeoCoordinate();
        //    mapaFarmacias.Center = locator.;
        //    mapaFarmacias.ZoomLevel = 10;
        //    FormatCoordinate(coordinate.Latitude, 'N', 'S'),
        //    FormatCoordinate(coordinate.Longitude, 'E', 'W'));

        //}

    }
}