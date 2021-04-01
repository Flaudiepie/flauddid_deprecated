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
    public class CommentExampleService : ICommentsService
    {
        public Task CreateAsync(ICollection<Comment> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Comment> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Comment>> GetAsync(string key)
        {
            var jsonFile = File.ReadAllText("ExampleData/comments.json");
            return Task.FromResult(JsonSerializer.Deserialize<ICollection<Comment>>(jsonFile));
        }

        public Task<ICollection<Comment>> UpdateAsync(ICollection<Comment> item)
        {
            throw new NotImplementedException();
        }
    }
}
