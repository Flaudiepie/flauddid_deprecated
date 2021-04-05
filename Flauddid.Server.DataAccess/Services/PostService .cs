using AutoMapper;
using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess.Services
{
    public class PostService : IPostService
    {
        private readonly RedditClient reddit;
        private readonly IMapper mapper;
        public PostService(RedditClient reddit, IMapper mapper)
        {
            this.reddit = reddit;
            this.mapper = mapper;
        }

        public Task CreateAsync(Domain.Entities.Post item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Domain.Entities.Post item)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Post> GetAsync(PostInfo key)
        {
            var post = reddit.Subreddit(key.SubReddit).Post($"t3_{key.ID}").About();
            return Task.FromResult(mapper.Map<Domain.Entities.Post>(post));
        }

        public Task UpdateAsync(Domain.Entities.Post post)
        {
            var originalPost = new Reddit.Controllers.Post(reddit.Account.Dispatch, id: post.Id, subreddit: post.Subreddit);
            if (post.VoteState == VoteState.Up)
            {
                originalPost.Upvote();
            }
            else if (post.VoteState == VoteState.Down)
            {
                originalPost.Downvote();
            }
            else
            {
                originalPost.Unvote();
            }
            return Task.CompletedTask;
        }
    }
}
