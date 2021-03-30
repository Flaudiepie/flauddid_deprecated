using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Entities
{
    public class SearchResult
    {
        public ICollection<SubReddit> SubReddits { get; set; }
        public ICollection<Post> Posts { get; set; }

        public SearchResult(ICollection<SubReddit> subReddits, ICollection<Post> posts)
        {
            SubReddits = subReddits;
            Posts = posts;
        }
    }
}
