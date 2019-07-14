using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Views;
using gigIt.Xamarin.Models;
using gigIt.Xamarin.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace gigIt.Xamarin
{
    public partial class TheApp : Application
    {
        public List<ShellViewItem> ShellViews { get; } = new List<ShellViewItem>();
        public NavigationPage Navigation { get; private set; }

        public TheApp()
        {
            ShellViews.Add(new ShellViewItem(0, gigItIcons.Ideas, "Sparks", gigItColors.gigitSpark, 0, () => new SparksView()));
            ShellViews.Add(new ShellViewItem(1, gigItIcons.Skills, "Skills", gigItColors.gigitWater, 1, () => new SkillsView()));

            InitializeComponent();

            //MasterView = new MasterView();
            MainPage = Navigation = new NavigationPage(new SparksView());
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("202020"));
            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.FromHex("CCCCCC"));
            NavigationPage.SetHasNavigationBar(MainPage, false);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
