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
    public partial class Contactenos : Contenedor
    {
        public Contactenos()
        {
            InitializeComponent();
        }

        private void Enviar_Clicked (object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}