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
        public string Title { get; set; }
        [Parameter]
        public string Content { get; set; }
        [Parameter]
        public string Author { get; set; }
        [Parameter]
        public PostType PostType { get; set; }
        [Parameter]
        public double UpVotes { get; set; }
        private string Votes { get; set; }

        protected override Task OnParametersSetAsync()
        {
            if (UpVotes > 999)
            {
                Votes = Math.Round((UpVotes / 1000), 1).ToString();
                Votes += "k";
            }
            else
            {
                Votes = UpVotes.ToString();
            }
            return base.OnParametersSetAsync();
        }
    }
}
