using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Platforms.Uap.Core;
using MvvmCross.ViewModels;
using Windows.UI.Xaml.Controls;

namespace gigIt.Xamarin.UWP
{
    public class Setup : MvxWindowsSetup
    {
        protected override IMvxApplication CreateApp()
        {
            return new UwpApp() as IMvxApplication;
        }

        //protected override IMvxTrace CreateDebugTrace()
        //{
        //    return new DebugTrace();
        //}
    }
}
