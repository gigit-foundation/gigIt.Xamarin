using System;
using System.Windows.Input;

using Xamarin.Forms;

using MvvmCross.Navigation;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public interface ISkillsViewModel : IAspectViewModel { }

    public class SkillsViewModel : AspectViewModel, ISkillsViewModel
    {
        //public IDataStore<Skills> DataStore => DependencyService.Get<IDataStore<Skills>>() ?? new MockSkillsStore();

        public SkillsViewModel(IMvxNavigationService navigation, IBloom bloom) : base(navigation, bloom)
        {
            Id = 2;
            IconGlyph = gigItIcons.Skills;
            Title = "Skills";
            TitleColor = gigItColors.gigitWater;
        }
    }
}