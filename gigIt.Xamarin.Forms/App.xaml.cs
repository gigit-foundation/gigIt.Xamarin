using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public List<AspectViewItem> AspectViews { get; }
        public Dictionary<int, Lazy<NavigationPage>> AspectPages { get; } = new Dictionary<int, Lazy<NavigationPage>>();
        public AspectViewItem CurrentAspect { get; private set; }

        public TheApp()
        {
            var items = new AspectViewItem[]
            {
                new AspectViewItem(1, gigItIcons.Spark,  "Sparks", gigItColors.gigitSpark, (si) => new SparksView(si)),
                new AspectViewItem(2, gigItIcons.Skills, "Skills", gigItColors.gigitWater, (si) => new SkillsView(si)),
                new AspectViewItem(3, gigItIcons.Actors, "People", gigItColors.gigitLife,  (si) => new PeopleView(si)),
                new AspectViewItem(4, gigItIcons.Work,   "Gigs",   gigItColors.gigitEarth, (si) => new GigsView(si)),
                new AspectViewItem(5, gigItIcons.Market, "Market", gigItColors.gigitSky,   (si) => new MarketView(si)),
            };
            AspectViews = items.ToList();
            CurrentAspect = AspectViews.First();

            foreach (var item in AspectViews)
            {
                // lazy load as needed
                var page = new Lazy<NavigationPage>(() =>
                {
                    var p = new NavigationPage(item.CreateView(item));
                    p.BarBackgroundColor = Color.FromHex("202020");
                    p.BarTextColor = Color.FromHex("CCCCCC");
                    NavigationPage.SetHasNavigationBar(p, false);
                    return p;
                });

                AspectPages.Add(item.Id, page);
            }

            InitializeComponent();

            // load the intial page
            MainPage = AspectPages[1].Value;
        }

        public async Task<AspectViewItem> NavigateToAspect(int id)
        {
            if (CurrentAspect.Id != id)
            {
                var page = AspectPages[id].Value;
                CurrentAspect = AspectViews.First((av) => av.Id == id);
                if (id == 1) await MainPage.Navigation.PopToRootAsync(false);
                else
                {
                    var lastPage = MainPage.Navigation.NavigationStack.LastOrDefault();
                    await MainPage.Navigation.PushAsync(page, false);
                    if (MainPage.Navigation.NavigationStack.Count > 2)
                        MainPage.Navigation.RemovePage(lastPage);
                }
            }
            return CurrentAspect;
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
