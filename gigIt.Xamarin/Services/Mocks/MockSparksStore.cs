using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.Services
{
    public class MockSparksStore : IDataStore<Spark>
    {
        List<Spark> items;

        public MockSparksStore()
        {
            items = new List<Spark>();
            var mockItems = new List<Spark>
            {
                new Spark { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Spark { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Spark { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Spark { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Spark { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Spark { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Spark item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Spark item)
        {
            var oldItem = items.Where((Spark arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Spark arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Spark> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Spark>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}