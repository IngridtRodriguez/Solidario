using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Solidario.Services;
using Solidario.Views;

namespace Solidario
{
    public partial class App : Application
    {

        public static Contenedor objContenedor;

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            objContenedor = new Contenedor();
            MainPage = objContenedor;
            // MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
