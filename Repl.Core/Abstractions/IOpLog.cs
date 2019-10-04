using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repl.Core.Abstractions
{
    public interface IOpLog
    {
        Task<List<Op>> GetOps(long minOpIdExclusive);
        Task AddOps(List<Op> ops);
    }
}
