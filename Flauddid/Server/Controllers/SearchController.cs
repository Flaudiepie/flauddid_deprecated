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
    public class SearchController : Controller
    {
        private readonly ISearchService searchService;
        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        [HttpGet("{suchbegriff}")]
        [Produces("application/json")]
        public async Task<ActionResult<SearchResult>> GetAsync([FromRoute] string suchbegriff)
        {
            var x = Ok(await searchService.GetAsync(suchbegriff));
            return x;
        }
    }
}
