using System;

using gigIt.Model;

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
