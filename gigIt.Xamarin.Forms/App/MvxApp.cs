using System;
using System.Collections.Generic;
using System.Text;

using MvvmCross;
using MvvmCross.IoC;

namespace gigIt.Xamarin.Forms
{
    public class MvxApp: MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.ConstructAndRegisterSingleton<ViewModels.IBloom, ViewModels.BloomViewModel>();

            RegisterAppStart<ViewModels.SparksViewModel>();

            // if you want to use a custom AppStart, you should replace the previous line with this one:
            // RegisterCustomAppStart<MyCustomAppStart>();
        }
    }
}
