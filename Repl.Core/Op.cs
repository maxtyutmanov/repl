using System;

namespace Repl.Core
{
    public class Op
    {
        public long OpId { get; set; }

        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public OpType Type { get; set; }
    }
}
