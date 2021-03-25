using Flauddid.Domain;
using Microsoft.AspNetCore.Components;
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

        private ICollection<string> posts;

        protected override async Task OnInitializedAsync()
        {
            posts = await PostService.GetAsync();

            await base.OnInitializedAsync();
        }
    }
}
