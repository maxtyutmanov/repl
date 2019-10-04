using System;
using System.Collections.Generic;
using System.Text;

namespace Repl.Core
{
    public class ReplPacket
    {
        public List<Op> Operations { get; set; }

        public List<object> ReferencedEntities { get; set; }

        public Dictionary<string, CollectionSyncBody> CollectionSyncs { get; set; }
    }

    public class CollectionSyncBody
    {
        public List<string> ActualIds { get; set; }

        public List<object> Entities { get; set; }
    }
}
