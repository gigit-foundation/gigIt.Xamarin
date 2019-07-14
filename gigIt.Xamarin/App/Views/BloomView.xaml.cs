﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace gigIt.Xamarin.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloomView : ContentView
    {
        public BloomView()
        {
            Bloom = new Command(() => StartBloom());
            Wilt = new Command(() => StartWilt());

            BindingContext = this;

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

        bool isOpen = false;
        public bool IsOpen
        {
            get { return isOpen; }
            set { SetProperty(ref isOpen, value); }
        }

        int iconSize = 48;
        public int IconSize
        {
            get { return iconSize; }
            set { SetProperty(ref iconSize, value); }
        }

        async void StartBloom()
        {
            if (IsOpen) return;

            IsOpen = true;
            this.BackgroundColor = Color.FromHex("44111111");
            await Task.WhenAll(new Task[]
            {
                // slide the whole thing up
                this.TranslateTo(0, -70, 200, Easing.SpringOut),
                // fan out
                btnSparks.TranslateTo(0, -70, 100, Easing.CubicInOut),
                btnSkills.TranslateTo(66.574, -21.6312, 100, Easing.CubicInOut),
                btnPeople.TranslateTo(41.1450, 56.6312, 100, Easing.CubicInOut),
                btnWork.TranslateTo(-41.1450, 56.6312, 100, Easing.CubicInOut),
                btnMarket.TranslateTo(-66.574, -21.6312, 100, Easing.CubicInOut),
                // scale buttons up to 1
                btnSparks.ScaleTo(1, 100, Easing.CubicInOut),
                btnSkills.ScaleTo(1, 100, Easing.CubicInOut),
                btnPeople.ScaleTo(1, 100, Easing.CubicInOut),
                btnWork.ScaleTo(1, 100, Easing.CubicInOut),
                btnMarket.ScaleTo(1, 100, Easing.CubicInOut),
                // make center smaller and move it up
                btnBloom.ScaleTo(0.65, 100, Easing.SpringOut),
                btnBloom.TranslateTo(0, -10, 100, Easing.SpringIn),
            });

        }

        async void StartWilt()
        {
            if (!IsOpen) return;

            await Task.WhenAll(new Task[]
            {
                // slide the whole thing back down
                this.TranslateTo(0, 0, 200, Easing.SpringIn),
                // recenter
                btnSparks.TranslateTo(0, 0, 100, Easing.CubicInOut),
                btnSkills.TranslateTo(0, 0, 100, Easing.CubicInOut),
                btnPeople.TranslateTo(0, 0, 100, Easing.CubicInOut),
                btnWork.TranslateTo(0, 0, 100, Easing.CubicInOut),
                btnMarket.TranslateTo(0, 0, 100, Easing.CubicInOut),
                // shrink buttons
                btnSparks.ScaleTo(0.1, 100, Easing.CubicInOut),
                btnSkills.ScaleTo(0.1, 100, Easing.CubicInOut),
                btnPeople.ScaleTo(0.1, 100, Easing.CubicInOut),
                btnWork.ScaleTo(0.1, 100, Easing.CubicInOut),
                btnMarket.ScaleTo(0.1, 100, Easing.CubicInOut),
                // reset main button
                btnBloom.ScaleTo(1, 100, Easing.SpringIn),
                btnBloom.TranslateTo(0, 0, 100, Easing.SpringIn),
            });

            IsOpen = false;
        }

        private void ToggleBloom(object sender, EventArgs e)
        {
            if (IsOpen) StartWilt();
            else StartBloom();
        }
    }
}