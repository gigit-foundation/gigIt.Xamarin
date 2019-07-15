using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.ViewModels
{
    public class PeopleViewModel : AspectViewModel
    {
        //public IDataStore<People> DataStore => DependencyService.Get<IDataStore<People>>() ?? new MockPeopleStore();

        public PeopleViewModel(ShellViewItem si) : base(si)
        {
        }
    }
}