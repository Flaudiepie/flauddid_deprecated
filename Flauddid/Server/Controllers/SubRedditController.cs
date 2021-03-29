using Flauddid.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubRedditController : Controller
    {
        private readonly ISubRedditService subRedditService;
        public SubRedditController(ISubRedditService subRedditService)
        {
            this.subRedditService = subRedditService;
        }

        [HttpGet("{name}")]
        [Produces("application/json")]
        public async Task<ActionResult<List<Comment>>> GetAsync([FromRoute] string name)
        {
            var x = Ok(await subRedditService.GetAsync(name));
            return x;
        }
    }
}
