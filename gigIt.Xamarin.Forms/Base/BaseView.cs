﻿using System;
using System.Collections.Generic;
using System.Text;
using XamForms = Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    public class BasePage<TViewModel> : MvxContentPage<TViewModel> 
        where TViewModel : class, IMvxViewModel
    {
        public BasePage()
        {
            XamForms.NavigationPage.SetHasNavigationBar(this, false);
            this.BackgroundColor = gigItColors.bodyBG;
            On<XamForms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}
