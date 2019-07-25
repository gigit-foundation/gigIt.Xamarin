﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.ViewModels;

namespace gigIt.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsView : AspectView
    {
        SkillsViewModel viewModel;

        public SkillsView(AspectViewItem si) : base(si)
        {
            BindingContext = viewModel = new SkillsViewModel(si);

            InitializeComponent();
        }
    }
}