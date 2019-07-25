using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.Services;
using gigIt.Xamarin.Views;

namespace gigIt.Xamarin.ViewModels
{
    public class AspectViewModel : BaseViewModel
    {
        public AspectViewModel(AspectViewItem si)
        {
            Aspect = si;
        }

        public AspectViewItem Aspect { get; }
    }
}
