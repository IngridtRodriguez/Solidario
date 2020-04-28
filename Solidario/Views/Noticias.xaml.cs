using Solidario.ViewModels;
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
    public partial class Noticias : Contenedor
    {
        NoticiasViewModel noticiasViewModel;
        public Noticias()
        {
            InitializeComponent();
            BindingContext = noticiasViewModel = new NoticiasViewModel();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            DisplayAlert("","Seleccionado","Ok");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (noticiasViewModel.noticias.Count == 0)
                noticiasViewModel.IsBusy = true;
        }
    }
}