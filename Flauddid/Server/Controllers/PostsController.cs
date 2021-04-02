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
            var x = Ok(await postsService.GetAsync());
            return x;
        }

        [HttpGet("{subreddit}/{id}")]
        public async Task<ActionResult<Post>> GetAsync(string id, string subreddit)
        {
            var x = Ok(await postService.GetAsync(new PostInfo(subreddit, id)));
            return x;
        }
    }
}
