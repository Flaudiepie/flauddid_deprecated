using Flauddid.Domain.Entities;
using Flauddid.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.ExampleInterfaces
{
    public interface IPostExampleService : IService<ICollection<Post>>
    {
    }
}
