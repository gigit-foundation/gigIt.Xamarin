using System;
using System.Collections.Generic;
using System.Text;
using gigIt.Xamarin.Views;
using Xamarin.Forms;

namespace gigIt.Xamarin.Models
{
    public class ShellViewItem
    {
        public ShellViewItem(int id, string icon, string title, Color titleColor, ushort location, Func<BaseView> viewCreate)
        {
            Id = id;
            IconGlyph = icon;
            Title = title;
            TitleColor = titleColor;
            IconLocation = location;
            CreateView = viewCreate;
        }

        public int Id { get; private set; }
        public string IconGlyph { get; private set; }
        public string Title { get; private set; }
        public Color TitleColor { get; private set; }
        public ushort IconLocation { get; private set; }
        public Func<BaseView> CreateView { get; private set; }
    }
}
