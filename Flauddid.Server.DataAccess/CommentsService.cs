using Flauddid.Domain;
using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess
{
    public class CommentsService : ICommentsService
    {
        private readonly RedditClient reddit;

        public CommentsService(RedditClient reddit)
        {
            this.reddit = reddit;
        }

        public Task CreateAsync(ICollection<Domain.Comment> item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ICollection<Domain.Comment> item)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Domain.Comment>> GetAsync(string id)
        {
            var comments = new Comments(reddit.Account.Dispatch, postId: id);
            return Task.FromResult(CommentUtilities.BuildCommentTree(comments.GetComments()));
        }

        public Task<ICollection<Domain.Comment>> UpdateAsync(ICollection<Domain.Comment> item)
        {
            throw new NotImplementedException();
        }
    }
}
