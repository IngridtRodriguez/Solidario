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
                        btnAtras.IsVisible = false;
                        frmcontactenos.IsVisible = true;
                        frmmapa.IsVisible = true;
                        break;
                    case "Contactenos":
                        objContentView = new Contactenos();
                        btnAtras.IsVisible = true;
                        this.frmBarraSuperior.IsVisible = true;
                        frmcontactenos.IsVisible = false;
                        frmmapa.IsVisible = true;
                        break;
                    case "Ubicacion":
                        objContentView = new Ubicacion();
                        this.frmBarraSuperior.IsVisible = true;
                        scrlContenedor.InputTransparent = true;
                        btnAtras.IsVisible = true;
                        frmcontactenos.IsVisible = true;
                        frmmapa.IsVisible = false;
                        break;
                    default:
                        throw new Exception("No existe vista: " + strVistaNueva);

                }
                //creacion del contenedor
                this.grdContenedor.Children.Clear();
                this.grdContenedor.Children.Add(objContentView);
                App.strVista = strVistaNueva;
            }
            catch (Exception ex)
            
            {
                DisplayAlert("PasoInformado", "MostrarVista: " + ex.Message, "OK");
            }
        }

        private  void frmAtras_Tapped(object sender, EventArgs e)
        {
            App.objContenedor.MostrarVista("Inicial");
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