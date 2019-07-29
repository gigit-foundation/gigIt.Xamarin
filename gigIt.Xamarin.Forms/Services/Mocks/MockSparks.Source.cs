using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Model;

namespace gigIt.Xamarin.Services
{
    public partial class MockSparksStore
    {
        private List<Spark> _Items = new List<Spark>
            {
                new Spark(Guid.NewGuid()) {
                    Title = "Product Map",
                    Notes ="Date for release 10/01.",
                    SparkType = SparkType.Todo
                },
                new Spark(Guid.NewGuid()) {
                    Title = "Berlin Trip",
                    Notes ="Don't forget your passport.",
                    SparkType = SparkType.Reminder
                },
                new Spark(Guid.NewGuid()) {
                    Title = "SHOES",
                    Notes ="Something light but easy to take off for TSA :/",
                    SparkType = SparkType.Shopping
                },
                new Spark(Guid.NewGuid()) {
                    Title = "gigIt GTO",
                    Notes ="Need an appropriate crowd funding strategy...",
                    SparkType = SparkType.Idea
                },
                new Spark(Guid.NewGuid()) {
                    Title = "Divergent Thinking",
                    Notes ="Keystone to creativity?",
                    SparkType = SparkType.Reference,
                    References = new List<ReferenceMaterial>() { _mockRefs[0] }
                },
                new Spark(Guid.NewGuid()) {
                    Title = "Screenshot",
                    Notes ="<enter description here>",
                    SparkType = SparkType.Unclassified,
                    References = new List<ReferenceMaterial>() { _mockRefs[1] }
                },
            };
    }
}
