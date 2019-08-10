using System;
using System.Collections.Generic;
using System.Text;
using gigIt.Xamarin.Forms.ViewModels;
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

            Mvx.IoCProvider.ConstructAndRegisterSingleton<IBloom, BloomViewModel>();

            Mvx.IoCProvider.ConstructAndRegisterSingleton<ISparksViewModel, SparksViewModel>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<ISkillsViewModel, SkillsViewModel>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IPeopleViewModel, PeopleViewModel>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IGigsViewModel, GigsViewModel>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IMarketViewModel, MarketViewModel>();

            //CreatableTypes()
            //    .Inherits<AspectViewModel>()
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();

            RegisterAppStart<SparksViewModel>();

            // if you want to use a custom AppStart, you should replace the previous line with this one:
            // RegisterCustomAppStart<MyCustomAppStart>();
        }
    }
}
