using Flauddid.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly IPostService postService;

        public MainController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet]
        private void GetPosts()
        {
            postService.GetData();
        }

    }
}
