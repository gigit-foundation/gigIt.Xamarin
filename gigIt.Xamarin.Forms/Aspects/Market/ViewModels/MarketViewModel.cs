using System;
using System.Windows.Input;

using Xamarin.Forms;

using MvvmCross.Navigation;

using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class MarketViewModel : AspectViewModel
    {
        //public IDataStore<Market> DataStore => DependencyService.Get<IDataStore<Market>>() ?? new MockMarketStore();

        public MarketViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 5;
            IconGlyph = gigItIcons.Market;
            Title = "Market";
            TitleColor = gigItColors.gigitSky;
        }
    }
}