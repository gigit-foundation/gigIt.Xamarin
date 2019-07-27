using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class GigsViewModel : AspectViewModel
    {
        //public IDataStore<Gigs> DataStore => DependencyService.Get<IDataStore<Gigs>>() ?? new MockGigsStore();

        public GigsViewModel(AspectViewItem si) : base(si)
        {
        }
    }
}