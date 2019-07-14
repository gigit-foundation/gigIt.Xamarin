using System;
using System.Windows.Input;

using Xamarin.Forms;
using gigIt.Xamarin.Services;

namespace gigIt.Xamarin.ViewModels
{
    public class SkillsViewModel : AspectViewModel
    {
        //public IDataStore<Skill> DataStore => DependencyService.Get<IDataStore<Skill>>() ?? new MockSkillsStore();

        public SkillsViewModel()
        {
            Title = "Skills";
            TitleColor = gigItColors.gigitWater;
            IconGlyph = gigItIcons.Skills;

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}