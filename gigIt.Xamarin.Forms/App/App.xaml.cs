using System;
using System.Linq;
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
        public List<ShellViewItem> ShellViews { get; }
        public Dictionary<int, Lazy<NavigationPage>> ShellPages { get; } = new Dictionary<int, Lazy<NavigationPage>>();
        //public NavigationPage RootPage { get; private set; }

        private int currentPage = 1;

        public TheApp()
        {
            var items = new ShellViewItem[]
            {
                new ShellViewItem(1, gigItIcons.Ideas,  "Sparks", gigItColors.gigitSpark, (si) => new SparksView(si)),
                new ShellViewItem(2, gigItIcons.Skills, "Skills", gigItColors.gigitWater, (si) => new SkillsView(si)),
                new ShellViewItem(3, gigItIcons.Skills, "People", gigItColors.gigitLife,  (si) => new PeopleView(si)),
                new ShellViewItem(4, gigItIcons.Skills, "Gigs",   gigItColors.gigitEarth, (si) => new GigsView(si)),
                new ShellViewItem(5, gigItIcons.Skills, "Market", gigItColors.gigitSky,   (si) => new MarketView(si)),
            };
            ShellViews = items.ToList();

            foreach(var item in ShellViews)
            {
                // lazy load as needed
                var page = new Lazy<NavigationPage>(() =>
                {
                    var p = new NavigationPage(item.CreateView(item));
                    p.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("202020"));
                    p.SetValue(NavigationPage.BarTextColorProperty, Color.FromHex("CCCCCC"));
                    NavigationPage.SetHasNavigationBar(p, false);
                    return p;
                });

                ShellPages.Add(item.Id, page);
            }

            InitializeComponent();

            // load the intial page
            MainPage = /*RootPage =*/ ShellPages[1].Value;
        }

        public async void NavigateToAspect(int id)
        {
            if (currentPage == id) return;
            var page = ShellPages[id].Value;
            currentPage = id;
            if (id == 1) await MainPage.Navigation.PopToRootAsync();
            else await MainPage.Navigation.PushModalAsync(page);
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
