using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flauddid.Domain.Interfaces
{
    public interface IService<T>
    {
        public Task<T> GetAsync();
        public Task CreateAsync(T item);
        public Task DeleteAsync(T item);
        public Task<T> UpdateAsync(T item);
    }
    public interface IService<TKey, TValue>
    {
        public Task<TValue> GetAsync(TKey key);
        public Task CreateAsync(TValue item);
        public Task DeleteAsync(TValue item);
        public Task<TValue> UpdateAsync(TValue item);
    }
}
