using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloomView : ContentView
    {
        public BloomView()
        {
            Bloom = new Command(async () => await StartBloom());
            Wilt = new Command(async () => await StartWilt());

            NavToSparks = new Command(() => NavToAspect(1));
            NavToSkills = new Command(() => NavToAspect(2));
            NavToPeople = new Command(() => NavToAspect(3));
            NavToWork   = new Command(() => NavToAspect(4));
            NavToMarket = new Command(() => NavToAspect(5));

            BindingContext = this;

            CurrentAspect = (Application.Current as TheApp).CurrentAspect;

            InitializeComponent();
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;
            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public ICommand Bloom { get; }
        public ICommand Wilt { get; }
        public ICommand NavToSparks { get; }
        public ICommand NavToSkills { get; }
        public ICommand NavToPeople { get; }
        public ICommand NavToWork { get; }
        public ICommand NavToMarket { get; }

        bool isOpen = false;
        public bool IsOpen
        {
            get { return isOpen; }
            set { SetProperty(ref isOpen, value); }
        }

        int iconSize = 35;
        public int IconSize
        {
            get { return iconSize; }
            set { SetProperty(ref iconSize, value); }
        }

        AspectViewItem currentAspect = null;
        public AspectViewItem CurrentAspect
        {
            get { return currentAspect; }
            set { SetProperty(ref currentAspect, value); }
        }

        async Task<bool> StartBloom()
        {
            if (IsOpen) return false;

            // do animations
            await Task.WhenAll(new Task[]
            {
                btnBloom.TranslateTo(0, -40, 125, Easing.SpringOut),
                btnBloom.FadeTo(0, 250, Easing.SpringOut),
                gridBloom.FadeTo(1, 125, Easing.SpringOut),
            });

            IsOpen = true;
            return true;
        }

        async Task<bool> StartWilt()
        {
            if (!IsOpen) return false;

            IsOpen = false;

            // do animations
            await Task.WhenAll(new Task[]
            {
                btnBloom.TranslateTo(0, 0, 125, Easing.SpringIn),
                btnBloom.FadeTo(1, 250, Easing.SpringOut),
                gridBloom.FadeTo(0, 125, Easing.SpringOut),
            });

            return true;
        }

        async void NavToAspect(int sid)
        {
            await StartWilt();
            CurrentAspect = await (Application.Current as TheApp).NavigateToAspect(sid);
        }

        public async void ToggleBloom(object sender, EventArgs e)
        {
            if (IsOpen) await StartWilt();
            else await StartBloom();
        }
    }
}