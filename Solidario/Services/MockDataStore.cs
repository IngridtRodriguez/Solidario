using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solidario.Models;

namespace Solidario.Services
{
    public class MockDataStore : IDataStore<Noticia>
    {
        readonly List<Noticia> items;

        public MockDataStore()
        {
            items = new List<Noticia>()
            {
                new Noticia { Id = Guid.NewGuid().ToString(), Titulo = "First item", Descripcion="This is an item description.", Hora=10},
                new Noticia { Id = Guid.NewGuid().ToString(), Titulo = "Second item",Descripcion="This is an item description.", Hora=9},
                new Noticia { Id = Guid.NewGuid().ToString(), Titulo = "Third item", Descripcion="This is an item description.", Hora=8 },
                new Noticia { Id = Guid.NewGuid().ToString(), Titulo = "Fourth item",Descripcion="This is an item description.", Hora=7 },
                new Noticia { Id = Guid.NewGuid().ToString(), Titulo = "Fifth item", Descripcion="This is an item description.", Hora=6 },
                new Noticia { Id = Guid.NewGuid().ToString(), Titulo = "Sixth item", Descripcion="This is an item description.", Hora=5 }
            };
        }

        public async Task<bool> AddItemAsync(Noticia item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Noticia item)
        {
            var oldItem = items.Where((Noticia arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Noticia arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Noticia> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Noticia>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}