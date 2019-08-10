using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MvvmCross;
using MvvmCross.Navigation;

using gigIt.Xamarin.Forms.Views;
using gigIt.Xamarin.Services;
using gigIt.Model;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public interface ISparksViewModel : IAspectViewModel { }

    public class SparksViewModel : AspectViewModel, ISparksViewModel
    {
        public IDataStore<Spark> DataStore => DependencyService.Get<IDataStore<Spark>>() ?? new MockSparksStore();

        public ObservableCollection<SparkTileViewModel> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public SparksViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 1;
            IconGlyph = gigItIcons.Spark;
            Title = "Sparks";
            TitleColor = gigItColors.gigitSpark;

            Items = new ObservableCollection<SparkTileViewModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Spark>(this, "AddItem", async (obj, item) =>
            {
                var spark = item as Spark;
                //var newItem = Mvx.IoCProvider.IoCConstruct<SparkTileViewModel>(spark);
                var newItem = new SparkTileViewModel(spark);
                Items.Add(newItem);
                await DataStore.AddItemAsync(spark);
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
                foreach (var spark in items)
                {
                    //var tile = Mvx.IoCProvider.IoCConstruct<SparkTileViewModel>(spark);
                    var tile = new SparkTileViewModel(spark);
                    Items.Add(tile);
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