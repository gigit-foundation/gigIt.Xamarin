using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.Views
{
    public class AspectView : BaseView
    {
        public AspectView(ShellViewItem si)
        {
            Aspect = si;
        }

        public ShellViewItem Aspect { get; }

    }
}
