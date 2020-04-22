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
            MostrarVista("Inicial");
        }
        public void MostrarVista(string strVistaNueva)
        {
            try
            {
                ContentView objContentView;
                scrlContenedor.InputTransparent = false;
                switch (strVistaNueva)
                {
                    case "Inicial":
                        objContentView = new Noticias();
                        this.frmBarraSuperior.IsVisible = true;
                        break;
                    case "Contactenos":
                        objContentView = new Contactenos();
                        this.frmBarraSuperior.IsVisible = true;
                        break;
                    case "Ubicacion":
                        objContentView = new Ubicacion();
                        this.frmBarraSuperior.IsVisible = true;
                        scrlContenedor.InputTransparent = true;
                        break;
                    default:
                        throw new Exception("No existe vista: " + strVistaNueva);

                }
            }
            catch (Exception ex)
            {
                DisplayAlert("PasoInformado", "MostrarVista: " + ex.Message, "OK");
            }
        }

        private void btnUbicaciones_Tapped(object sender, EventArgs e)
        {
            App.objContenedor.MostrarVista("Ubicacion");

        }
        private void btnContactenos_Tapped(object sender, EventArgs e)
        {
            App.objContenedor.MostrarVista("Contactenos");
        }

    }
}