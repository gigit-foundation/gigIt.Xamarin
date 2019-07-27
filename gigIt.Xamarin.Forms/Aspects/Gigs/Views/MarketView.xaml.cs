using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Forms.Models;
using gigIt.Xamarin.Forms.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GigsView : AspectView
    {
        GigsViewModel viewModel;

        public GigsView(AspectViewItem si) : base(si)
        {
            BindingContext = viewModel = new GigsViewModel(si);

            InitializeComponent();
        }
    }
}