using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.ViewModels;

namespace gigIt.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketView : AspectView
    {
        MarketViewModel viewModel;

        public MarketView(ShellViewItem si) : base(si)
        {
            BindingContext = viewModel = new MarketViewModel(si);

            InitializeComponent();
        }
    }
}