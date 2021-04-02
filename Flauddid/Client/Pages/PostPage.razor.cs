using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Pages
{
    public partial class PostPage : ComponentBase
    {
        [Parameter]
        public string SubReddit { get; set; }
        [Parameter]
        public string ID { get; set; }
        private Domain.Entities.Post Post { get; set; }
        [Inject]
        public IPostService postService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Post = await postService.GetAsync(new PostInfo(SubReddit, ID));

            await base.OnInitializedAsync();
        }
    }
}
