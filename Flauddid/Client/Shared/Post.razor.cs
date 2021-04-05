using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
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
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        [Inject]
        private IPostService postService { get; set; }

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

        protected void OpenPost()
        {
            NavigationManager.NavigateTo($"/r/{post.Subreddit}/{post.Id}");
        }

        protected void PostUpVote()
        {
            post.VoteState = post.VoteState == VoteState.Up ? VoteState.Neutral : VoteState.Up;
            postService.UpdateAsync(post);
        }

        protected void PostDownVote()
        {
            post.VoteState = post.VoteState == VoteState.Down ? VoteState.Neutral : VoteState.Down;
            postService.UpdateAsync(post);
        }
    }
}
