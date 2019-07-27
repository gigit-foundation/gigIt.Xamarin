using System;
using System.Windows.Input;

using Xamarin.Forms;

using MvvmCross.Navigation;

using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class PeopleViewModel : AspectViewModel
    {
        //public IDataStore<People> DataStore => DependencyService.Get<IDataStore<People>>() ?? new MockPeopleStore();

        public PeopleViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 3;
            IconGlyph = gigItIcons.Actors;
            Title = "People";
            TitleColor = gigItColors.gigitLife;
        }
    }
}