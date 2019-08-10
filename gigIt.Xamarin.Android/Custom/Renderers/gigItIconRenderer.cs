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

[assembly: XamForms.ExportRenderer(typeof(gigIt.Xamarin.Forms.Controls.gigItIconLabel), typeof(gigIt.Xamarin.Droid.Custom.Renderers.gigItIconLabelRenderer))]
[assembly: XamForms.ExportRenderer(typeof(gigIt.Xamarin.Forms.Controls.gigItIconButton), typeof(gigIt.Xamarin.Droid.Custom.Renderers.gigItIconButtonRenderer))]
namespace gigIt.Xamarin.Droid.Custom.Renderers
{
    public class gigItIconLabelRenderer : LabelRenderer
    {
        public gigItIconLabelRenderer(Context ctx) : base(ctx)
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

    public class gigItIconButtonRenderer : ButtonRenderer
    {
        public gigItIconButtonRenderer(Context ctx) : base(ctx)
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