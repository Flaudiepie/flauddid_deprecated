using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Flauddid.Client.DataAccess.Services
{
    public class SearchService : ISearchService
    {
        private readonly HttpClient httpClient;
        public SearchService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task CreateAsync(SearchResult item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SearchResult item)
        {
            throw new NotImplementedException();
        }

        public async Task<SearchResult> GetAsync(string key)
        {
            return await httpClient.GetFromJsonAsync<SearchResult>("api/search");
        }

        public Task<SearchResult> UpdateAsync(SearchResult item)
        {
            throw new NotImplementedException();
        }
    }
}
