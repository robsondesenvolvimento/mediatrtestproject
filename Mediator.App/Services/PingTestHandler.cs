using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.App.Services
{
    public class PingTestHandler : IRequestHandler<PingTest, string>
    {
        public async Task<string> Handle(PingTest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult("Pong");
        }
    }
}
