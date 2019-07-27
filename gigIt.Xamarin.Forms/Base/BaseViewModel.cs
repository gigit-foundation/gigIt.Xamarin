using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

using MvvmCross.ViewModels;
using MvvmCross.Navigation;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

//        protected bool SetProperty<T>(ref T backingStore, T value,
//            [CallerMemberName]string propertyName = "",
//            Action onChanged = null)
//        {
//            if (EqualityComparer<T>.Default.Equals(backingStore, value))
//                return false;

//            backingStore = value;
//            onChanged?.Invoke();
//            OnPropertyChanged(propertyName);
//            return true;
//        }

//#region INotifyPropertyChanged
//        public event PropertyChangedEventHandler PropertyChanged;
//        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
//        {
//            var changed = PropertyChanged;
//            if (changed == null)
//                return;

//            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
//#endregion
    }
}
