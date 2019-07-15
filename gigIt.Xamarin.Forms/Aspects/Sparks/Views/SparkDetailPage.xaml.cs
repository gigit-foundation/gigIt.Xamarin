using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.ViewModels;

namespace gigIt.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        SparkDetailViewModel viewModel;

        public ItemDetailPage(SparkDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Spark
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new SparkDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}