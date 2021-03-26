using Flauddid.Domain;
using Reddit;
using Reddit.Controllers;
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

        public Task CreateAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Domain.Post>> GetAsync()
        {
            var x = reddit.FrontPage;
            var frontPage = reddit.FrontPage.Select((element) =>
            {
                if (element is (Reddit.Controllers.LinkPost))
                {
                    return Domain.Post.GetLinkPostAutoMapperConfig().Map<Domain.Post>(element);
                }
                else
                {
                    return Domain.Post.GetSelfPostAutoMapperConfig().Map<Domain.Post>(element);
                }
            }).ToList();
            return Task.FromResult<ICollection<Domain.Post>>(frontPage);
        }

        public Task<ICollection<Domain.Post>> UpdateAsync(ICollection<Domain.Post> item)
        {
            throw new NotImplementedException();
        }
    }
}
