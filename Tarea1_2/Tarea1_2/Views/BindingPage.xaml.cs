using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            Boolean todobien = false;
            if (txtnom.Text != null)
            {
                todobien = true;
            }
            else 
            {
                await DisplayAlert("ALERTA","Te Falto ingresar el Nombre","OK"); todobien = false;
            }
            if (txtape.Text != null)
            {
                todobien = true;
            }
            else
            {
                await DisplayAlert("ALERTA", "Te Falto ingresar el Apellido", "OK"); todobien = false;
            }
            if (txtedad.Text != null)
            {
                todobien = true;
            }
            else
            {
                await DisplayAlert("ALERTA", "Te Falto ingresar la Edad", "OK"); todobien = false;
            }
            if (txtemail.Text != null)
            {
                todobien = true;
            }
            else
            {
                await DisplayAlert("ALERTA", "Te Falto ingresar el Email", "OK"); todobien = false;
            }
            if (todobien)
            {
                var persona = new Models.Personas
                {
                    nombre = txtnom.Text,
                    apellido = txtape.Text,
                    edad = Convert.ToInt32(txtedad.Text),
                    correo = txtemail.Text
                };
                var secondPage = new Views.ResultPage();
                secondPage.BindingContext = persona;
                await Navigation.PushAsync(secondPage);
            }
        }
    }
}