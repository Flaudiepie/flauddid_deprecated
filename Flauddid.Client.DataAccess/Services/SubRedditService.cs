using Flauddid.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Flauddid.Client.DataAccess
{
    public class SubRedditService : ISubRedditService
    {
        private readonly HttpClient httpClient;

        public SubRedditService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task CreateAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }

        public async Task<SubReddit> GetAsync(string key)
        {
            return await httpClient.GetFromJsonAsync<SubReddit>($"api/subreddit/{key}");
        }

        public Task<SubReddit> UpdateAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }
    }
}
