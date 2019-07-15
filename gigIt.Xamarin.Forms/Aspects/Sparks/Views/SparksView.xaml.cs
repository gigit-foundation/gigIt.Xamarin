using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.Views;
using gigIt.Xamarin.ViewModels;

namespace gigIt.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SparksView : AspectView
    {
        SparksViewModel viewModel;

        public SparksView(ShellViewItem si) : base(si)
        {
            BindingContext = viewModel = new SparksViewModel(si);

            InitializeComponent();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Spark;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new SparkDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}