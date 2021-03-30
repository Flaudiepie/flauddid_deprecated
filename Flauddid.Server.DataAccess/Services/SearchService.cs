using AutoMapper;
using Flauddid.Domain;
using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using Reddit;
using Reddit.Inputs.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess.Services
{
    public class SearchService : ISearchService
    {
        private readonly RedditClient redditClient;
        private readonly IMapper mapper;

        public SearchService(RedditClient redditClient, IMapper mapper)
        {
            this.redditClient = redditClient;
            this.mapper = mapper;
        }

        public Task CreateAsync(SearchResult item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SearchResult item)
        {
            throw new NotImplementedException();
        }

        public Task<SearchResult> GetAsync(string suchEingabe)
        {
            var resultSubReddits = redditClient.SearchSubreddits(new SearchGetSearchInput(suchEingabe))
                                               .Select(x => mapper.Map<SubReddit>(x))
                                               .ToList();
            var resultPosts = redditClient.Search(new SearchGetSearchInput(suchEingabe))
                                          .Select(x => mapper.Map<Post>(x))
                                          .ToList();
            return Task.FromResult(new SearchResult(resultSubReddits, resultPosts));
        }

        public Task<SearchResult> UpdateAsync(SearchResult item)
        {
            throw new NotImplementedException();
        }
    }
}
