using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Pages
{
    public partial class SubredditPage : ComponentBase
    {
        [Parameter]
        public string SubRedditName { get; set; }
        private SubReddit SubReddit { get; set; }
        [Inject]
        private ISubRedditService subRedditService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            SubReddit = await subRedditService.GetAsync(SubRedditName);
            await base.OnInitializedAsync();
        }
    }
}
