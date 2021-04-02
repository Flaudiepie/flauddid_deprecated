using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Entities
{
    public struct PostInfo
    {
        public string SubReddit { get; set; }
        public string ID { get; set; }

        public PostInfo(string subReddit, string ID)
        {
            SubReddit = subReddit;
            this.ID = ID;
        }
    }
}
