using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

using FFImageLoading.Forms.Platform;
using FFImageLoading.Svg.Forms;

using gigIt.Xamarin.Forms;

namespace gigIt.Xamarin.Droid
{
    [Activity(Label = "gigIt", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<MvxApp, FormApp>, MvxApp, FormApp>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            CachedImageRenderer.Init(true);
            var ignore = typeof(SvgCachedImage);

            base.OnCreate(savedInstanceState);
        }
    }
}