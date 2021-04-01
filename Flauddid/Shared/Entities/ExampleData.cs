using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Entities
{
    public class ExampleData
    {
        public ICollection<Post> posts { get; set; }
        public ICollection<SubReddit> subReddits{ get; set; }
        public ICollection<Comment> comments{ get; set; }
    }
}
