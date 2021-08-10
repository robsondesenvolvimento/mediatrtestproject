using MediatR;

namespace Mediator.App.Commands
{
    public class ProdutoCreateCommand : IRequest<string>
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
