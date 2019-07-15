using System;
using System.Collections.Generic;
using System.Text;
using XamForms = Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace gigIt.Xamarin.Views
{
    public class BaseView : XamForms.ContentPage
    {
        public BaseView()
        {
            XamForms.NavigationPage.SetHasNavigationBar(this, false);
            On<XamForms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
