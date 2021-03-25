using Flauddid.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IPostService PostService { get; set; }

        protected async Task GetPosts()
        {
            await Task.Factory.StartNew(() =>
            {
                PostService.GetData();
            });
        }
    }
}
