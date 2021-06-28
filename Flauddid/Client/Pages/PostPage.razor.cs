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
        private string Votes { get; set; }

        [Inject]
        public IPostService postService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Post = await postService.GetAsync(new PostInfo(SubReddit, ID));
            if (Post.UpVotes > 999)
            {
                Votes = Math.Round((double)(Post.UpVotes / 1000), 1).ToString();
                Votes += "k";
            }
            else
            {
                Votes = Post.UpVotes.ToString();
            }
            await base.OnInitializedAsync();
        }

        protected void PostUpVote()
        {
            Post.VoteState = Post.VoteState == VoteState.Up ? VoteState.Neutral : VoteState.Up;
            postService.UpdateAsync(Post);
        }

        protected void PostDownVote()
        {
            Post.VoteState = Post.VoteState == VoteState.Down ? VoteState.Neutral : VoteState.Down;
            postService.UpdateAsync(Post);
        }
    }
}
