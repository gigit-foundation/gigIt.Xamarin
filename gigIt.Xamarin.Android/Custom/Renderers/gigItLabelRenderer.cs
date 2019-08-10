using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamForms = Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: XamForms.ExportRenderer(typeof(gigIt.Xamarin.Forms.Controls.gigItLabel), typeof(gigIt.Xamarin.Droid.Custom.Renderers.gigItLabelRenderer))]
namespace gigIt.Xamarin.Droid.Custom.Renderers
{
    public class gigItLabelRenderer : LabelRenderer
    {
        public gigItLabelRenderer(Context ctx) : base(ctx)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<XamForms.Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Context.Assets,
                    "Fonts/Aller.ttf");
            }
        }
    }
}