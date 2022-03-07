using Manager.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Manager.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> CreateAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task RemoveAsync(long id);
        Task<T> GetAsync(long id);
        Task<List<T>> GetAllAsync();
    }
}