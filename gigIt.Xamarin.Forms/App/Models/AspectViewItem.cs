﻿using System;
using System.Collections.Generic;
using System.Text;
using gigIt.Xamarin.Views;
using Xamarin.Forms;

namespace gigIt.Xamarin.Models
{
    public class AspectViewItem
    {
        public AspectViewItem(int id, string icon, string title, Color titleColor, Func<AspectViewItem, BaseView> viewCreate)
        {
            Id = id;
            IconGlyph = icon;
            Title = title;
            TitleColor = titleColor;
            CreateView = viewCreate;
        }

        public int Id { get; private set; }
        public string IconGlyph { get; private set; }
        public string Title { get; private set; }
        public Color TitleColor { get; private set; }
        public Func<AspectViewItem, BaseView> CreateView { get; set; }
    }
}