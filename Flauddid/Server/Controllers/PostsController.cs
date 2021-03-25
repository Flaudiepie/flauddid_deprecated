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
    public class PostsController : Controller
    {
        private readonly IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<string>>> GetActio()
        {
            return Ok(await postService.GetAsync());
        }
    }
}
