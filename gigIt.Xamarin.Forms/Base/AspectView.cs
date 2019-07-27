using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Xamarin.Forms.Models;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = true, Animated = false)]
    public class AspectView<TViewModel> : BasePage<TViewModel> 
        where TViewModel : class, IMvxViewModel
    {
    }
}
