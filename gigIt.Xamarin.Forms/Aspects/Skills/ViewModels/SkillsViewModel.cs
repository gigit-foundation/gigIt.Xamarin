using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.ViewModels
{
    public class SkillsViewModel : AspectViewModel
    {
        //public IDataStore<Skills> DataStore => DependencyService.Get<IDataStore<Skills>>() ?? new MockSkillsStore();

        public SkillsViewModel(AspectViewItem si) : base(si)
        {
        }
    }
}