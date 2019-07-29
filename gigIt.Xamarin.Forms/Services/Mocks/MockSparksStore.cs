using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using gigIt.Model;

namespace gigIt.Xamarin.Services
{
    public partial class MockSparksStore : IDataStore<Spark>
    {
        public MockSparksStore()
        {
        }

        public async Task<bool> AddItemAsync(Spark item)
        {
            _Items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Spark item)
        {
            var oldItem = _Items.Where((Spark arg) => arg.ID == item.ID).FirstOrDefault();
            _Items.Remove(oldItem);
            _Items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            var oldItem = _Items.Where((Spark arg) => arg.ID == id).FirstOrDefault();
            _Items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Spark> GetItemAsync(Guid id)
        {
            return await Task.FromResult(_Items.FirstOrDefault(s => s.ID == id));
        }

        public async Task<IEnumerable<Spark>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_Items);
        }
    }
}