using Flauddid.Domain.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Shared
{
    public partial class Post : ComponentBase
    {
        [Parameter]
        public Domain.Entities.Post post { get; set; }
        private string Votes { get; set; }

        protected override Task OnParametersSetAsync()
        {
            if (post.UpVotes > 999)
            {
                Votes = Math.Round((double)(post.UpVotes / 1000), 1).ToString();
                Votes += "k";
            }
            else
            {
                Votes = post.UpVotes.ToString();
            }
            return base.OnParametersSetAsync();
        }
    }
}
