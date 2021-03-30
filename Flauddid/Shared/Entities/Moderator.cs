using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Entities
{
    public class Moderator
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Moderator(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
