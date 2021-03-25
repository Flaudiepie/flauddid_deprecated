using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain
{
    public interface IService<T>
    {
        public Task<T> GetAsync();
        public Task CreateAsync(T item);
        public Task DeleteAsync(T item);
        public Task<T> UpdateAsync(T item);
    }
}
