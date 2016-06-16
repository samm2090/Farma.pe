﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Farma.pe.models;
using Newtonsoft.Json;

namespace Farma.pe
{
    public partial class RegistrarUsuario : PhoneApplicationPage
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }


        private void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {

            if (txtNombre.Text == String.Empty || txtApePat.Text == String.Empty || txtApeMat.Text == String.Empty ||
                txtCorreo.Text == String.Empty || txtCorreo.Text == String.Empty)
            {
                MessageBox.Show("Falta completar un dato");
            }
            else {

                Persona persona = new Persona();
                persona.NOM_PER = txtNombre.Text;
                persona.APEP_PER = txtApePat.Text;
                persona.APEM_PER = txtApeMat.Text;
                persona.FNAC_PER = txtFecNac.Value;

                string jsonData = JsonConvert.SerializeObject(persona);

                WebClient wc = new WebClient();
                wc.Headers["Content-type"] = "application/json";
                wc.Encoding = System.Text.UTF8Encoding.UTF8;

                Uri url = new Uri("http://localhost:48262/api/Producto");


            }

        }
    }
}