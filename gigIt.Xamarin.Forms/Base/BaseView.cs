using System;
using System.Collections.Generic;
using System.Text;
using XamForms = Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace gigIt.Xamarin.Forms.Views
{
    public class BaseView : XamForms.ContentPage
    {
        public BaseView()
        {
            XamForms.NavigationPage.SetHasNavigationBar(this, false);
            this.BackgroundColor = gigItColors.bodyBG;
            On<XamForms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
