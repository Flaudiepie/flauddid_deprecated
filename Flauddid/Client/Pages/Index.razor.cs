using Flauddid.Domain;
using Microsoft.AspNetCore.Components;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Pages
{
    partial class Index : ComponentBase
    {
        [Inject]
        public IPostService PostService { get; set; }

        private ICollection<Domain.Post> posts;

        protected override async Task OnInitializedAsync()
        {
            posts = await PostService.GetAsync();

            await base.OnInitializedAsync();
        }
    }
}
