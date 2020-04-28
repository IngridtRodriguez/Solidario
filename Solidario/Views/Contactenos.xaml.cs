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
    public partial class Contactenos : ContentPage
    {
        public Contactenos()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
        }

        async void Enviar_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}