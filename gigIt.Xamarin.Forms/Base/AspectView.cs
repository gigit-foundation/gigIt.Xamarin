using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.Views
{
    public class AspectView : BaseView
    {
        public AspectView(AspectViewItem si = null)
        {
            Aspect = si;
        }

        public AspectViewItem Aspect { get; }

    }
}
