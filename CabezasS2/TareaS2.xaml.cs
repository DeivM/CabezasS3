using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CabezasS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TareaS2 : ContentPage
    {
        public TareaS2(String Usario)
        {
            InitializeComponent();
            lblUsuConectado.Text = Usario;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double parcial1 = Convert.ToDouble(txtParcial1.Text);
                double parcial2 = Convert.ToDouble(txtParcial2.Text);
                double examenP1 = Convert.ToDouble(txtExamenP1.Text);
                double examenP2 = Convert.ToDouble(txtExamenP2.Text);

                double promedioP1 = (parcial1 * 0.3) + (examenP1 * 0.2);
                
                double promedioP2 = (parcial2 * 0.3) + (examenP2 * 0.2);

                txtTotal1.Text = promedioP1.ToString();
                
                txtTotal2.Text = promedioP2.ToString();

                double promediofinal = promedioP1 + promedioP2;

                txtPFinal.Text = promediofinal.ToString();

                if (Convert.ToDouble(txtPFinal.Text) >= 7)
                {
                    DisplayAlert("Mensaje de alerta", "Aprobado", "Cerrar");
                }
                else
                {
                    if (Convert.ToDouble(txtPFinal.Text) >= 5 && Convert.ToDouble(txtPFinal.Text) <= 6.9)
                    {
                        DisplayAlert("Mensaje de alerta", "Complementario", "Cerrar");
                    }

                    DisplayAlert("Mensaje de alerta", "Reprobado", "Cerrar");

                }

            }
            catch (Exception ex)
            {

                DisplayAlert("ERROR", ex.Message, "Cerrar");

            }
        }
    }
}