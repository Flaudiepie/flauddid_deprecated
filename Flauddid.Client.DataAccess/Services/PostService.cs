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

        public Task CreateAsync(ICollection<Domain.Entities.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Domain.Entities.Post> item)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Domain.Entities.Post>> GetAsync()
        {
            return await httpClient.GetFromJsonAsync<List<Domain.Entities.Post>>("api/posts" );
        }

        public Task<ICollection<Domain.Entities.Post>> UpdateAsync(ICollection<Domain.Entities.Post> item)
        {
            throw new NotImplementedException();
        }
    }
}
