using MediatR;

namespace OnionApp.Application.Features.Orders.Commands.CreateOrderCommand
{
    public record CreateOrderCommand(string FirmaId, string ProductId, string CustomerName) : IRequest<CreateOrderCommandResponse>;
}