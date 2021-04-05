using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Client.DataAccess.Services
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

        public async Task<ICollection<Comment>> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<ICollection<Comment>>($"api/comments/{id}");
        }

        public Task UpdateAsync(ICollection<Comment> item)
        {
            throw new NotImplementedException();
        }
    }
}
