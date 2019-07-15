using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.ViewModels
{
    public class MarketViewModel : AspectViewModel
    {
        //public IDataStore<Market> DataStore => DependencyService.Get<IDataStore<Market>>() ?? new MockMarketStore();

        public MarketViewModel(ShellViewItem si) : base(si)
        {
        }
    }
}