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
            var originalPost = new Reddit.Controllers.Post(reddit.Account.Dispatch, id: post.Id, subreddit: post.Subreddit).Info();
            switch (post.VoteState)
            {
                case VoteState.Up:
                    if (!originalPost.IsUpvoted)
                        originalPost.Upvote();
                    break;
                case VoteState.Down:
                    if (!originalPost.IsDownvoted)
                        originalPost.Downvote();
                    break;
                default:
                    originalPost.Unvote();
                    break;
            }
            return Task.CompletedTask;
        }
    }
}
