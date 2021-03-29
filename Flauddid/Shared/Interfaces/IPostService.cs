using Microsoft.Extensions.Configuration;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    // excpliciter als ICollection<string> könnte besser sein aka vlt. ein model dafür erstellen
    public interface IPostService : IService<ICollection<Domain.Post>>
    {
    }
}
