﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    public interface ICommentsService : IService<string, ICollection<Comment>>
    {
    }
}