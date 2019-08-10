using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MvvmCross.ViewModels;

using gigIt.Xamarin.Forms.ViewModels;
using MvvmCross.Forms.Views;
using MvvmCross.Base;
using MvvmCross.Binding.BindingContext;
using MvvmCross;

namespace gigIt.Xamarin.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloomView : MvxContentView<BloomViewModel>
    {
        public BloomView()
        {
            InitializeComponent();

            // wire up the animation interaction
            var set = this.CreateBindingSet<BloomView, BloomViewModel>();
            set.Bind(this).For(view => view.BloomInteraction).To(viewModel => viewModel.BloomInteraction).OneWay();
            set.Apply();
        }

        private IMvxInteraction<BloomViewModel.BloomAction> _bloomInteraction;
        public IMvxInteraction<BloomViewModel.BloomAction> BloomInteraction
        {
            get => _bloomInteraction;
            set
            {
                if (_bloomInteraction != null)
                    _bloomInteraction.Requested -= OnBloomActionRequested;

                _bloomInteraction = value;

                if (_bloomInteraction != null)
                    _bloomInteraction.Requested += OnBloomActionRequested;
            }
        }

        private async void OnBloomActionRequested(object sender, MvxValueEventArgs<BloomViewModel.BloomAction> eventArgs)
        {
            var action = eventArgs.Value;
            // do animations
            switch (action)
            {
                case BloomViewModel.BloomAction.Bloom:
                    await Task.WhenAll(new Task[]
                    {
                        btnBloom.TranslateTo(0, -40, 125, Easing.SpringOut),
                        btnBloom.FadeTo(0, 250, Easing.SpringOut),
                        gridBloom.FadeTo(1, 125, Easing.SpringOut),
                    });
                    break;
                case BloomViewModel.BloomAction.Wilt:
                    await Task.WhenAll(new Task[]
                    {
                        btnBloom.TranslateTo(0, 0, 125, Easing.SpringIn),
                        btnBloom.FadeTo(1, 250, Easing.SpringOut),
                        gridBloom.FadeTo(0, 125, Easing.SpringOut),
                    });
                    break;
            }
        }
    }
}