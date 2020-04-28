using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Solidario.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contenedor : ContentPage
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void IconoMapa_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("","Icono Mapa Clicked","Ok");
        }

        async void IconoContacto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Contactenos()));
        }

    }
}