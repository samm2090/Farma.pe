using System;
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
            else
            {

                Usuario usuario = new Usuario();
                usuario.NOM_USU = txtCorreo.Text;
                usuario.PASS_USU = txtContrasena.Text;
                usuario.CORREO_USU = txtCorreo.Text;


                string jsonData = JsonConvert.SerializeObject(usuario);

                WebClient wc = new WebClient();
                wc.Headers["Content-type"] = "application/json";
                wc.Encoding = System.Text.UTF8Encoding.UTF8;

                Uri url = new Uri("http://localhost:54973/api/USUARIO");

                wc.UploadStringCompleted += new UploadStringCompletedEventHandler(RegistrarUsu);
                wc.UploadStringAsync(url, "POST", jsonData);

            }

        }

        private void RegistrarUsu(object sender, UploadStringCompletedEventArgs e)
        {
            try
            {
                Usuario usuario = JsonConvert.DeserializeObject<Usuario>(e.Result);

                if (usuario != null)
                {
                    Persona persona = new Persona();
                    persona.NOM_PER = txtNombre.Text;
                    persona.APEP_PER = txtApePat.Text;
                    persona.APEM_PER = txtApeMat.Text;
                    persona.FNAC_PER = txtFecNac.Value;
                    persona.USUARIO = usuario;

                    string jsonData = JsonConvert.SerializeObject(persona);

                    WebClient wc = new WebClient();
                    wc.Headers["Content-type"] = "application/json";
                    wc.Encoding = System.Text.UTF8Encoding.UTF8;

                    Uri url = new Uri("http://localhost:54973/api/PERSONA");

                    wc.UploadStringCompleted += new UploadStringCompletedEventHandler(RegistrarPersona);
                    wc.UploadStringAsync(url, "POST", jsonData);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrarPersona(object sender, UploadStringCompletedEventArgs e)
        {
            try
            {

                //Persona persona = JsonConvert.DeserializeObject<Persona>(e.Result);

                    MessageBox.Show("¡Te haz registrado! Ingresa usando tu correo y contraseña");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}