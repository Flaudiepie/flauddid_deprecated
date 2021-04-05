using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flauddid.Client.DataAccess.Services
{
    public class PostService : IPostService
    {
        private readonly HttpClient httpClient;

        public PostService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task CreateAsync(Domain.Entities.Post item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Domain.Entities.Post item)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.Entities.Post> GetAsync(PostInfo key)
        {
            return await httpClient.GetFromJsonAsync<Domain.Entities.Post>($"api/posts/{key.SubReddit}/{key.ID}");

        }

        public async Task UpdateAsync(Domain.Entities.Post item)
        {
            await httpClient.PutAsJsonAsync($"api/posts/vote", item);
        }
    }
}
