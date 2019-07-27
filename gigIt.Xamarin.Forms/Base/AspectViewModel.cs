using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
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
