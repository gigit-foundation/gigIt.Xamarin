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

[assembly: XamForms.ExportRenderer(typeof(gigIt.Xamarin.Controls.gigItIconLabel), typeof(gigIt.Xamarin.Droid.Custom.Renderers.gigItLabelRenderer))]
[assembly: XamForms.ExportRenderer(typeof(gigIt.Xamarin.Controls.gigItIconButton), typeof(gigIt.Xamarin.Droid.Custom.Renderers.gigItButtonRenderer))]
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
                    "Fonts/gigit.ttf");
            }
        }
    }

    public class gigItButtonRenderer : ButtonRenderer
    {
        public gigItButtonRenderer(Context ctx) : base(ctx)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<XamForms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Context.Assets,
                    "Fonts/gigit.ttf");
            }
        }
    }
}