using AutoMapper;
using Flauddid.Domain;
using Reddit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess
{
    public class SubRedditService : ISubRedditService
    {
        private readonly RedditClient redditClient;
        private readonly IMapper mapper;

        public SubRedditService(RedditClient redditClient, IMapper mapper)
        {
            this.redditClient = redditClient;
            this.mapper = mapper;
        }

        public Task CreateAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }

        public Task<SubReddit> GetAsync(string name)
        {
            var subReddit = redditClient.Subreddit(name).About();
            return Task.FromResult(mapper.Map<SubReddit>(subReddit));
        }

        public Task<SubReddit> UpdateAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }
    }
}
