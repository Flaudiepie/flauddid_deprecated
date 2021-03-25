using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    public interface IPostService
    {
        public ICollection<string> GetData();
    }
}
