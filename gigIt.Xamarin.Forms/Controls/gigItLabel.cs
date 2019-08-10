using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace gigIt.Xamarin.Forms.Controls
{
    public class gigItLabel : Label
    {
        public gigItLabel()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.UWP:
                    {
                        FontFamily = @"/Assets/Fonts/Aller.ttf#Aller Trial";
                        break;
                    }
                case Device.Android:
                    {
                        FontFamily = @"Aller Trial";
                        break;
                    }
                case Device.iOS:
                    {
                        FontFamily = @"Aller Trial";
                        break;
                    }
            }
        }
    }
}
