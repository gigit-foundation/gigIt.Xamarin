using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Forms.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketView : AspectView<MarketViewModel>
    {
        public MarketView()
        {
            InitializeComponent();
        }
    }
}