using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class MarketViewModel : AspectViewModel
    {
        //public IDataStore<Market> DataStore => DependencyService.Get<IDataStore<Market>>() ?? new MockMarketStore();

        public MarketViewModel(AspectViewItem si) : base(si)
        {
        }
    }
}