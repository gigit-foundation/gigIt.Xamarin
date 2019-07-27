using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using MvvmCross.Navigation;

using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class AspectViewModel : BaseViewModel
    {
        public IMvxNavigationService Navigation { get; }

        public AspectViewModel(IMvxNavigationService navigation, IBloom bloom)
        {
            Navigation = navigation;
            Bloom = bloom;
        }

        int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        string iconGlyph;
        public string IconGlyph
        {
            get { return iconGlyph; }
            set { SetProperty(ref iconGlyph, value); }
        }

        string title;
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

        public IBloom Bloom { get; }
    }
}
