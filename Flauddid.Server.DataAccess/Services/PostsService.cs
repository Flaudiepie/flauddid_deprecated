using AutoMapper;
using Flauddid.Domain.Interfaces;
using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess.Services
{
    public class PostsService : IPostsService
    {
        private readonly RedditClient reddit;
        private readonly IMapper mapper;
        public PostsService(RedditClient reddit, IMapper mapper)
        {
            this.reddit = reddit;
            this.mapper = mapper;
        }

        public Task CreateAsync(ICollection<Domain.Entities.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Domain.Entities.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Domain.Entities.Post>> GetAsync()
        {
            var x = reddit.FrontPage;
            var frontPage = reddit.FrontPage.Select((element) =>
            {
                if (element is LinkPost)
                {
                    return mapper.Map<Domain.Entities.Post>(element);
                }
                else
                {
                    return mapper.Map<Domain.Entities.Post>(element);
                }
            }).ToList();
            return Task.FromResult<ICollection<Domain.Entities.Post>>(frontPage);
        }

        public Task<ICollection<Domain.Entities.Post>> UpdateAsync(ICollection<Domain.Entities.Post> item)
        {
            throw new NotImplementedException();
        }
    }
}
