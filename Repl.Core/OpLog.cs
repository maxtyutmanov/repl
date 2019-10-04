using Repl.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repl.Core
{
    public class OpLog : IOpLog
    {
        public Task AddOps(List<Op> ops)
        {
            throw new NotImplementedException();
        }

        public Task<List<Op>> GetOps(long minOpIdExclusive)
        {
            throw new NotImplementedException();
        }
    }
}
