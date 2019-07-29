using System;
using System.Windows.Input;

using Xamarin.Forms;

using MvvmCross.Navigation;


namespace gigIt.Xamarin.Forms.ViewModels
{
    public class GigsViewModel : AspectViewModel
    {
        //public IDataStore<Gigs> DataStore => DependencyService.Get<IDataStore<Gigs>>() ?? new MockGigsStore();

        public GigsViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 4;
            IconGlyph = gigItIcons.Work;
            Title = "Gigs";
            TitleColor = gigItColors.gigitEarth;
        }
    }
}