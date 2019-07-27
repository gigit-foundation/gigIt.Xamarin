using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Forms.Models;
using gigIt.Xamarin.Forms.ViewModels;

namespace gigIt.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : AspectView
    {
        PeopleViewModel viewModel;

        public PeopleView(AspectViewItem si) : base(si)
        {
            BindingContext = viewModel = new PeopleViewModel(si);

            InitializeComponent();
        }
    }
}