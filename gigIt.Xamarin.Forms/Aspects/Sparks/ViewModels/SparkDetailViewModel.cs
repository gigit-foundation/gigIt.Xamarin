using System;

using gigIt.Xamarin.Forms.Models;

namespace gigIt.Xamarin.Forms.ViewModels
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
