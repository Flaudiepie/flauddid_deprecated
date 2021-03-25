using Flauddid.Domain;
using Reddit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess
{
    public class PostService : IPostService
    {
        private readonly RedditClient reddit;

        public PostService(RedditClient reddit)
        {
            this.reddit = reddit;
        }

        public Task CreateAsync(ICollection<string> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<string> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<string>> GetAsync()
        {
            var x = reddit.FrontPage;
            Console.WriteLine(x);
            return Task.FromResult<ICollection<string>>(Enumerable.Range(0, 1).Select(i => i.ToString()).ToArray());
        }

        public Task<ICollection<string>> UpdateAsync(ICollection<string> item)
        {
            throw new NotImplementedException();
        }
    }
}
