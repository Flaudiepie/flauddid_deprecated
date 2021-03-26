using AutoMapper;
using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }

        [MapTo("")]
        public int DownVotes { get; set; }
        public int UpVotes { get; set; }
        public DateTime Edited { get; set; }

        [MapTo("IsDownvoted")]
        public bool IsDownVoted { get; set; }

        [MapTo("IsUpvoted")]
        public bool IsUpVoted { get; set; }
        public bool NSFW { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }
        public bool Removed { get; set; }
        public string Thumbnail { get; set; }

        public static IMapper GetSelfPostAutoMapperConfig()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Reddit.Controllers.SelfPost, Post>()
                .ForMember(dest => dest.Content, opt =>
                {
                    opt.MapFrom(src => src.SelfText);
                });
            }).CreateMapper();
        }

        public static IMapper GetLinkPostAutoMapperConfig()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Reddit.Controllers.LinkPost, Post>()
                .ForMember(dest => dest.Content, opt =>
                {
                    opt.MapFrom(src => src.Listing.Media != null ? src.Listing.Media.ToString() : src.URL);
                }).ForMember(dest => dest.Path, opt =>
                {
                    opt.MapFrom(src => src.Permalink);
                });
            }).CreateMapper();
        }
    }
}
