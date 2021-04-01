using AutoMapper;
using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Entities
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public int DownVotes { get; set; }
        public int UpVotes { get; set; }
        public DateTime Edited { get; set; }

        [MapTo("IsDownvoted")]
        public bool IsDownVoted { get; set; }

        [MapTo("IsUpvoted")]
        public bool IsUpVoted { get; set; }
        public bool NSFW { get; set; }
        public bool Spoiler { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }
        public bool Removed { get; set; }
        public string Thumbnail { get; set; }
        public double UpVodeRatio { get; set; }
        public string Subreddit { get; set; }
        public string URL { get; set; }
        public PostType PostType { get; set; }
    }
}
