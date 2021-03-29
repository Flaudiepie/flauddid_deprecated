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
    public class CommentsService : ICommentsService
    {
        private readonly HttpClient httpClient;

        public CommentsService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task CreateAsync(ICollection<Comment> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Comment> item)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Domain.Comment>> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<ICollection<Domain.Comment>>($"api/comments/{id}");
        }

        public Task<ICollection<Comment>> UpdateAsync(ICollection<Domain.Comment> item)
        {
            throw new NotImplementedException();
        }
    }
}
