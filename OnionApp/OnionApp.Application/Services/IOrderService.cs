using OnionApp.Application.Features.Orders.Commands.CreateOrderCommand;

namespace OnionApp.Application.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrderCommand request);
    }
}
