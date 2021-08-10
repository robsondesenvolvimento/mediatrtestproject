using Mediator.App.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.App.Repositories
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private static Dictionary<int, Produto> _produtos = new();

        public async Task Add(Produto item)
        {
            item.Id = _produtos.OrderByDescending(x => x.Key).FirstOrDefault().Key + 1;

            await Task.Run(() => _produtos.Add(item.Id, item));
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await Task.Run(() => _produtos.Values.ToList());
        }
    }
}
