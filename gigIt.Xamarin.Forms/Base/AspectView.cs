using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Xamarin.Forms.Models;
using MvvmCross.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    public class AspectView<TViewModel> : BaseView<TViewModel> 
        where TViewModel : class, IMvxViewModel
    {
    }
}
