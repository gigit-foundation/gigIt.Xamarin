using System;
using System.Windows.Input;

using Xamarin.Forms;

using MvvmCross.Navigation;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public interface IMarketViewModel : IAspectViewModel { }

    public class MarketViewModel : AspectViewModel, IMarketViewModel
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