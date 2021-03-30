using Flauddid.Domain.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Shared
{
    public partial class NavMenu : ComponentBase
    {
        [Inject]
        public ISearchService searchService { get; set; }

        public string searchInput { get; set; }

        protected async Task GetSearchResults()
        {
            var x = await searchService.GetAsync(searchInput);
        }
    }
}
