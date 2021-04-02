using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess.Services
{
    public class PostExampleService : IPostsService
    {
        public Task CreateAsync(ICollection<Post> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Post> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Post>> GetAsync()
        {
            var jsonFile = File.ReadAllText("ExampleData/posts.json");
            return Task.FromResult(JsonSerializer.Deserialize<ICollection<Post>>(jsonFile));
        }

        public Task<ICollection<Post>> UpdateAsync(ICollection<Post> item)
        {
            throw new NotImplementedException();
        }
    }
}
