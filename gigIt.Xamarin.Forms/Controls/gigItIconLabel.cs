using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace gigIt.Xamarin.Forms.Controls
{
    public class gigItIconLabel : Label
    {
        public gigItIconLabel()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.UWP:
                    {
                        FontFamily = @"/Assets/Fonts/gigit.ttf#gigit";
                        break;
                    }
                case Device.Android:
                    {
                        FontFamily = @"gigit";
                        break;
                    }
                case Device.iOS:
                    {
                        FontFamily = @"gigit";
                        break;
                    }
            }
            VerticalOptions = LayoutOptions.Center;
            HorizontalOptions = LayoutOptions.Center;
        }
    }
}
