using System;

using gigIt.Xamarin.Models;

namespace gigIt.Xamarin.ViewModels
{
    public class SparkDetailViewModel : BaseViewModel
    {
        public Spark Spark { get; }

        public SparkDetailViewModel(Spark item)
        {
            Spark = item;
        }
    }
}
