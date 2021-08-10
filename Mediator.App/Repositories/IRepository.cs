using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mediator.App.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task Add(T item);
    }
}
