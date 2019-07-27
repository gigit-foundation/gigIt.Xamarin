using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class PeopleViewModel : AspectViewModel
    {
        //public IDataStore<People> DataStore => DependencyService.Get<IDataStore<People>>() ?? new MockPeopleStore();

        public PeopleViewModel(AspectViewItem si) : base(si)
        {
        }
    }
}