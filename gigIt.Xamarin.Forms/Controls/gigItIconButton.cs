﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace gigIt.Xamarin.Forms.Controls
{
    public class gigItIconButton : Button
    {
        public gigItIconButton()
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
        }
    }
}
