using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : Controller
    {
        private readonly ICommentsService commentService;
        public CommentsController(ICommentsService commentService)
        {
            this.commentService = commentService;
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        public async Task<ActionResult<List<Comment>>> GetAsync([FromRoute] string id)
        {
            var x = Ok(await commentService.GetAsync(id));
            return x;
        }
    }
}
