using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Forms.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace gigIt.Xamarin.Forms
{
    public partial class FormApp : Application
    {
        public FormApp()
        {
            InitializeComponent();
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
