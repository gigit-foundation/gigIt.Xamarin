using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.Views
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
