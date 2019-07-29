using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Model;
using gigIt.Xamarin.Forms.ViewModels;

namespace gigIt.Xamarin.Forms.Views
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

            var item = new Spark(Guid.NewGuid())
            {
                Title = "New Spark",
                Notes = "Welcome to gigIt! This Spark will remain in your daily list until you decide what to do with it :)"
            };

            viewModel = new SparkDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}