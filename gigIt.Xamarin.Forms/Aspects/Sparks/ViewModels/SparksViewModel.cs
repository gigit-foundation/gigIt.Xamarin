using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

using Xamarin.Forms;

using MvvmCross;
using MvvmCross.Navigation;

using gigIt.Xamarin.Forms.Views;
using gigIt.Xamarin.Services;
using gigIt.Model;
using System.IO;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public interface ISparksViewModel : IAspectViewModel { }

    public class SparksViewModel : AspectViewModel, ISparksViewModel
    {
        public IDataStore<Spark> DataStore => DependencyService.Get<IDataStore<Spark>>() ?? new MockSparksStore();

        ObservableCollection<Spark> _MySparks;
        public ObservableCollection<Spark> MySparks
        {
            get { return _MySparks; }
            private set { SetProperty(ref _MySparks, value); }
        }


        public ObservableCollection<Spark> Following { get; } = new ObservableCollection<Spark>();
        public ObservableCollection<Spark> Hot { get; } = new ObservableCollection<Spark>();

        public Command LoadItemsCommand { get; private set; }

        public SparksViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 1;
            IconGlyph = gigItIcons.Spark;
            Title = "Sparks";
            TitleColor = gigItColors.gigitSpark;

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Spark>(this, "AddItem", async (obj, item) =>
            {
                var spark = item as Spark;
                MySparks.Add(spark);
                await DataStore.AddItemAsync(spark);
            });
        }

#region Properties

        Spark _SelectedSpark;
        public Spark SelectedSpark
        {
            get { return _SelectedSpark; }
            set { SetProperty(ref _SelectedSpark, value); }
        }

        Spark _SelectedFollowing;
        public Spark SelectedFollowing
        {
            get { return _SelectedFollowing; }
            set { SetProperty(ref _SelectedFollowing, value); }
        }

        Spark _SelectedHot;
        public Spark SelectedHot
        {
            get { return _SelectedHot; }
            set { SetProperty(ref _SelectedHot, value); }
        }

        #endregion

        public override async Task Initialize()
        {
            await base.Initialize();

            await ExecuteLoadItemsCommand();
        }

        public override Task UserCreate()
        {
            // navigate to create vm
            return Task.CompletedTask;
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                MySparks = new ObservableCollection<Spark>(await DataStore.GetItemsAsync(true));
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