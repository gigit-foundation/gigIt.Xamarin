using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;
using gigIt.Xamarin.ViewModels;

namespace gigIt.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : AspectView
    {
        PeopleViewModel viewModel;

        public PeopleView(ShellViewItem si) : base(si)
        {
            BindingContext = viewModel = new PeopleViewModel(si);

            InitializeComponent();
        }
    }
}