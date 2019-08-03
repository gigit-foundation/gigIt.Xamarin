using System;

using gigIt.Model;

namespace gigIt.Xamarin.Forms.ViewModels
{
    public class SparkTileViewModel : BaseViewModel
    {
        public ISpark Spark { get; }


        public SparkTileViewModel(ISpark item)
        {
            Spark = item;
        }
    }
}
