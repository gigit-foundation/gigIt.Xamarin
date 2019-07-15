using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.ViewModels;

namespace gigIt.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GigsView : AspectView
    {
        GigsViewModel viewModel;

        public GigsView(ShellViewItem si) : base(si)
        {
            BindingContext = viewModel = new GigsViewModel(si);

            InitializeComponent();
        }
    }
}