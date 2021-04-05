using Flauddid.Domain;
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
    public class PostsController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IPostService postService;

        public PostsController(IPostsService postsService, IPostService postService)
        {
            this.postsService = postsService;
            this.postService = postService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Post>>> GetAsync()
        {
            return Ok(await postsService.GetAsync());
        }

        [HttpGet("{subreddit}/{id}")]
        public async Task<ActionResult<Post>> GetAsync(string id, string subreddit)
        {
            return Ok(await postService.GetAsync(new PostInfo(subreddit, id)));
        }

        [HttpPut("vote")]
        public async Task<ActionResult<Post>> UpdateAsync([FromBody] Post post)
        {
            await postService.UpdateAsync(post);
            return Ok();
        }
    }
}
