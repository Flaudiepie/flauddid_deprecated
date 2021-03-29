using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Reddit.Controllers.SelfPost, Post>()
                .ForMember(dest => dest.Content, opt =>
                {
                    opt.MapFrom(src => src.SelfText);
                }).ForMember(dest => dest.Path, opt =>
                {
                    opt.MapFrom(src => src.Permalink);
                });
            CreateMap<Reddit.Controllers.LinkPost, Post>()
                .ForMember(dest => dest.Content, opt =>
                {
                    opt.MapFrom(src => src.Listing.Media != null ? src.Listing.Media.ToString() : src.URL);
                }).ForMember(dest => dest.Path, opt =>
                {
                    opt.MapFrom(src => src.Permalink);
                }).ForMember(dest => dest.UpVodeRatio, opt =>
                {
                    opt.MapFrom(src => src.UpvoteRatio);
                });
            CreateMap<Reddit.Controllers.Subreddit, SubReddit>()
                .ForMember(dest => dest.Moderators, opt =>
                {
                    opt.MapFrom(src => src.Moderators.Select(x => new Moderator(x.Id, x.Name)).ToList());
                });

        }
    }
}
