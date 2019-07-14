using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.RadialMenu.Models;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.Services;
using gigIt.Xamarin.Resources;
using gigIt.Xamarin.Views;

namespace gigIt.Xamarin.ViewModels
{
    public class AspectViewModel : BaseViewModel
    {
        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        Color titleColor;
        public Color TitleColor
        {
            get { return titleColor; }
            set { SetProperty(ref titleColor, value); }
        }

        string iconGlyph;
        public string IconGlyph
        {
            get { return iconGlyph; }
            set { SetProperty(ref iconGlyph, value); }
        }
    }
}
