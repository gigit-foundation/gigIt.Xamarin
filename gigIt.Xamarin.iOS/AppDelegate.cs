using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

using MvvmCross.Forms.Platforms.Ios.Core;

using FFImageLoading.Forms.Platform;
using FFImageLoading.Svg.Forms;

using gigIt.Xamarin.Forms;
using XamForms = Xamarin.Forms;

namespace gigIt.Xamarin.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<MvxApp, FormApp>, MvxApp, FormApp>
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            CachedImageRenderer.Init();
            var ignore = typeof(SvgCachedImage);

            XamForms.Forms.SetFlags("CollectionView_Experimental");

            var result = base.FinishedLaunching(app, options);

            return result;
        }
    }
}
