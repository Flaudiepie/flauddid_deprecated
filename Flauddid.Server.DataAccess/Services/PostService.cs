using AutoMapper;
using Flauddid.Domain;
using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess
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

        public Task CreateAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Domain.Post>> GetAsync()
        {
            var x = reddit.FrontPage;
            var frontPage = reddit.FrontPage.Select((element) =>
            {
                if (element is LinkPost)
                {
                    return mapper.Map<Domain.Post>(element);
                }
                else
                {
                    return mapper.Map<Domain.Post>(element);
                }
            }).ToList();
            return Task.FromResult<ICollection<Domain.Post>>(frontPage);
        }

        public Task<ICollection<Domain.Post>> UpdateAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }
    }
}
