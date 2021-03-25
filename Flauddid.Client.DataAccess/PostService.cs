using Flauddid.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
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

        public Task CreateAsync(ICollection<string> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<string> item)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<string>> GetAsync()
        {
            return await httpClient.GetFromJsonAsync<string[]>("api/posts");
        }

        public Task<ICollection<string>> UpdateAsync(ICollection<string> item)
        {
            throw new NotImplementedException();
        }
    }
}
