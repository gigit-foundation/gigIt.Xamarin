using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using gigIt.Xamarin.Forms.Models;
using gigIt.Xamarin.Forms.Views;
using gigIt.Xamarin.Services;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class SparksViewModel : AspectViewModel
    {
        public IDataStore<Spark> DataStore => DependencyService.Get<IDataStore<Spark>>() ?? new MockSparksStore();

        public ObservableCollection<Spark> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public SparksViewModel(AspectViewItem si) : base(si)
        {
            Items = new ObservableCollection<Spark>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Spark>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Spark;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
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