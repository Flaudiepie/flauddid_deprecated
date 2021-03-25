using Flauddid.Domain;
using Reddit;
using System;
using System.Collections.Generic;

namespace Flauddid.DataAccess
{
    public class PostService : IPostService
    {
        private readonly RedditClient reddit;

        public ICollection<string> GetData()
        {
            var x = reddit.FrontPage;
            Console.WriteLine(x);
            return null;
        }
    }
}
