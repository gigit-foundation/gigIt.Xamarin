using System;
using System.Collections.Generic;
using System.Text;

using gigIt.Model;

namespace gigIt.Xamarin.Services
{
    public partial class MockSparksStore
    {
        private static DateTime _Now = DateTime.Now;

        private static List<ReferenceMaterial> _mockRefs = new List<ReferenceMaterial>()
        {
            new ReferenceMaterial() {
                Type = ReferenceType.Link,
                LinkOther = "Divergent Thinking",
                LinkType = LinkType.HTML,
                // Snapshot = new Snapshot() { Type = SnapshotType.Screenshot, }
                Link = "https://en.m.wikipedia.org/wiki/Divergent_thinking",
            },
            new ReferenceMaterial() {
                Type = ReferenceType.File,
                LinkOther = "Screenshot",
                LinkType = LinkType.Screenshot,
                // Snapshot = new Snapshot() { Type = SnapshotType.Screenshot, }
                Link = "",
            },
        };
    }
}
