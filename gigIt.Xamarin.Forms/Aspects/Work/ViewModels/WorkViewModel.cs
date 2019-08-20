using System;
using System.Windows.Input;

using Xamarin.Forms;

using MvvmCross.Navigation;


namespace gigIt.Xamarin.Forms.ViewModels
{
    public interface IWorkViewModel : IAspectViewModel { }

    public class WorkViewModel : AspectViewModel, IWorkViewModel
    {
        //public IDataStore<Gigs> DataStore => DependencyService.Get<IDataStore<Gigs>>() ?? new MockGigsStore();

        public WorkViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 4;
            IconGlyph = gigItIcons.Work;
            Title = "Work";
            TitleColor = gigItColors.gigitEarth;
        }
    }
}