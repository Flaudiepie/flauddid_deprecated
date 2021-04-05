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
    public class SubRedditExampleService : ISubRedditService
    {
        public Task CreateAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }

        public Task<SubReddit> GetAsync(string key)
        {
            var jsonFile = File.ReadAllText("ExampleData/subreddit.json");
            return Task.FromResult(JsonSerializer.Deserialize<SubReddit>(jsonFile));
        }

        public Task UpdateAsync(SubReddit item)
        {
            throw new NotImplementedException();
        }
    }
}
