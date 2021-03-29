using Flauddid.Domain;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flauddid.Client.DataAccess
{
    public class PostService : IPostService
    {
        private readonly HttpClient httpClient;

        public PostService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task CreateAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Domain.Post>> GetAsync()
        {
            return await httpClient.GetFromJsonAsync<List<Domain.Post>>("api/posts" );
        }

        public Task<ICollection<Domain.Post>> UpdateAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }
    }
}
