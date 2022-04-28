using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CabezasS2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            String Usuario = txtUsuario.Text;
            String Clave = txtClave.Text;
            if ((Usuario == "estudiante2021") && (Clave == "uisrael2021"))
            {
                await Navigation.PushAsync(new TareaS2(Usuario));
                            }
            else
            {
                await DisplayAlert("Mensaje de alerta", "Datos Incorrectos", "Cerrar");
                
            }

        }
    }
}
