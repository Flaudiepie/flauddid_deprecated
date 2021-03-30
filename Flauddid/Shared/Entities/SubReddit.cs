using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Entities
{
    public class SubReddit
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Sidebar { get; set; }
        public int Subscribers { get; set; }
        public int ActiveUserCount { get; set; }
        public string URL { get; set; }
        public string BannerImg { get; set; }
        public string CommunityIcon { get; set; }
        public ICollection<Moderator> Moderators { get; set; }
        public string Description { get; set; }
        public string BannerBackgroundColor { get; set; }
        public string SubmitLinkLabel { get; set; }
        public string Lang { get; set; }
        public string PrimaryColor { get; set; }
        public bool Over18 { get; set; }
        public DateTime? Created { get; set; }

    }
}
