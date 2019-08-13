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
        public IMvxCommand ToggleAdmin => new MvxCommand(() =>
        {
            ShowAdmin = !ShowAdmin;
        });
        public IMvxCommand TapCreate => new MvxCommand(async () =>
        {
            await Aspect.UserCreate();
        });
        public IMvxCommand GetSearchResults => new MvxCommand(() =>
        {
        });

        bool _ShowAdmin = false;
        public bool ShowAdmin
        {
            get { return _ShowAdmin; }
            set { SetProperty(ref _ShowAdmin, value); }
        }

        string _SearchText;
        public string SearchText
        {
            get { return _SearchText; }
            set { SetProperty(ref _SearchText, value); }
        }


    }
}
