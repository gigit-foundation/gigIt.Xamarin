﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Model;
using gigIt.Xamarin.Forms.Views;
using gigIt.Xamarin.Forms.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SparksView : AspectView<SparksViewModel>
    {
        public SparksView()
        {
            InitializeComponent();
        }
    }
}