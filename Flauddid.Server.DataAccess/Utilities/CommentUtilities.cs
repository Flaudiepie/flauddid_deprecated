using Flauddid.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Server.DataAccess.Utilties
{
    static class CommentUtilities
    {
        public static ICollection<Domain.Entities.Comment> BuildCommentTree(List<Reddit.Controllers.Comment> comments)
        {
            var output = new List<Domain.Entities.Comment>();
            foreach (var x in comments)
            {
                var replies = BuildCommentTree(x.Replies);
                output.Add(new Domain.Entities.Comment(x.Id, x.Body, x.Author, x.UpVotes - x.DownVotes, x.Created, x.Edited, replies));
            }
            return output;
        }
    }
}
