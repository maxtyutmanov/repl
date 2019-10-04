using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repl.Core;

namespace Repl.WebApi.Controllers
{
    [Route("api/internal/replication")]
    [ApiController]
    public class ReplicationController : Controller
    {
        [HttpGet]
        [Route("packets/{opId}")]
        public IActionResult Get(long opId)
        {

        }

        [HttpPost]
        [Route("packets")]
        public IActionResult Post(ReplPacket packet)
        {

        }
    }
}
