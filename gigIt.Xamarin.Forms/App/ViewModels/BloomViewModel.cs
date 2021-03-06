﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

using Xamarin.Forms;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public interface IBloom
    {
        IMvxCommand Bloom { get; }
        IMvxCommand Wilt { get; }
        IMvxCommand NavToSparks { get; }
        IMvxCommand NavToSkills { get; }
        IMvxCommand NavToPeople { get; }
        IMvxCommand NavToWork { get; }
        IMvxCommand NavToMarket { get; }
    }

    public class BloomViewModel : BaseViewModel, IBloom
    {
        public enum BloomAction
        {
            Bloom,
            Wilt
        }

        public IMvxNavigationService Navigation { get; }

        public BloomViewModel(IMvxNavigationService navigation)
        {
            Navigation = navigation;
        }

        public IMvxCommand Bloom =>       new MvxCommand(() => StartBloom());
        public IMvxCommand Wilt =>        new MvxCommand(() => StartWilt());
        public IMvxCommand NavToSparks => new MvxCommand(() => NavToAspect<ISparksViewModel>());
        public IMvxCommand NavToSkills => new MvxCommand(() => NavToAspect<ISkillsViewModel>());
        public IMvxCommand NavToPeople => new MvxCommand(() => NavToAspect<IPeopleViewModel>());
        public IMvxCommand NavToWork   => new MvxCommand(() => NavToAspect<IWorkViewModel>());
        public IMvxCommand NavToMarket => new MvxCommand(() => NavToAspect<IMarketViewModel>());

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

        async void NavToAspect<TViewModel>() where TViewModel : class, IMvxViewModel
        {
            var vm = Mvx.IoCProvider.Resolve<TViewModel>();
            await Navigation.Navigate(vm);
            // StartWilt();
        }

        private MvxInteraction<BloomAction> _bloomInteraction = new MvxInteraction<BloomAction>();

        public IMvxInteraction<BloomAction> BloomInteraction => _bloomInteraction;

        bool StartBloom()
        {
            if (IsOpen) return false;

            _bloomInteraction.Raise(BloomAction.Bloom);

            IsOpen = true;
            return true;
        }

        bool StartWilt()
        {
            if (!IsOpen) return false;

            IsOpen = false;

            _bloomInteraction.Raise(BloomAction.Wilt);

            return true;
        }

    }
}
