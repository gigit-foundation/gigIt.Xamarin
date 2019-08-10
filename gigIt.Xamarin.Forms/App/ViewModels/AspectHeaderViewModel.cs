using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class AspectHeaderViewModel : BaseViewModel
    {
        public AspectHeaderViewModel(AspectViewModel aspect)
        {
            Aspect = aspect;
        }

        public AspectViewModel Aspect { get; }
        public IMvxCommand ToggleFilters => new MvxCommand(() =>
        {
            ShowFilters = !ShowFilters;
            ShowCreate = false;
        });
        public IMvxCommand ToggleCreate => new MvxCommand(() =>
        {
            ShowCreate = !ShowCreate;
            ShowFilters = false;
        });
        public IMvxCommand GetSearchResults => new MvxCommand(() =>
        {
        });

        bool _ShowFilters = false;
        public bool ShowFilters
        {
            get { return _ShowFilters; }
            set { SetProperty(ref _ShowFilters, value); }
        }

        bool _ShowCreate = false;
        public bool ShowCreate
        {
            get { return _ShowCreate; }
            set { SetProperty(ref _ShowCreate, value); }
        }


        string _SearchText;
        public string SearchText
        {
            get { return _SearchText; }
            set { SetProperty(ref _SearchText, value); }
        }


    }
}
