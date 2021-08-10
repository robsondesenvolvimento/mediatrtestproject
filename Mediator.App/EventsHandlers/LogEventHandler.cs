using Mediator.App.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.App.EventsHandlers
{
    public class LogEventHandler : INotificationHandler<ProdutoCreateNotification>, INotificationHandler<ErroNotification>
    {
        public Task Handle(ProdutoCreateNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"CRIACAO: '{notification.Id} " + $"- {notification.Nome} - {notification.Preco}'");
            });
        }

        public Task Handle(ErroNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ERRO: '{notification.Erro} \n {notification.PilhaErro}'");
            });
        }
    }
}
