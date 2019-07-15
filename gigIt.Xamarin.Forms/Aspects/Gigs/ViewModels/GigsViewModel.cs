using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.ViewModels
{
    public class GigsViewModel : AspectViewModel
    {
        //public IDataStore<Gigs> DataStore => DependencyService.Get<IDataStore<Gigs>>() ?? new MockGigsStore();

        public GigsViewModel(ShellViewItem si) : base(si)
        {
        }
    }
}