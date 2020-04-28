using Solidario.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Solidario.ViewModels
{
    public class NoticiasViewModel : BaseViewModel
    {
        public ObservableCollection<Noticia> noticias { get; set; }
        public Command comandoCargarNoticias { get; set; }

        public NoticiasViewModel()
        {
            Title = "Noticias";
            noticias = new ObservableCollection<Noticia>();
            comandoCargarNoticias = new Command(async () => await EjecutarCarga());
        }

        async Task EjecutarCarga()
        {
            IsBusy = true;

            try
            {
                noticias.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    noticias.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
