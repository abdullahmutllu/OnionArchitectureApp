

using OnionApp.Application.Features.Orders.Commands.CreateOrderCommand;
using OnionApp.Application.Services;
using OnionApp.Domain;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.OrderRepositories;

namespace OnionApp.Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderCommandRepository _orderCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IOrderCommandRepository orderCommandRepository,IUnitOfWork unitOfWork)
        {
            _orderCommandRepository= orderCommandRepository;
            _unitOfWork= unitOfWork;
        }
        public async Task CreateOrder(CreateOrderCommand request)
        {
            Order order = new()
            {
                Id = Guid.NewGuid().ToString(),
                CreeatedDate = DateTime.Now,
                CustomerName = request.CustomerName,
                FirmaId = request.FirmaId,
                OrderDate= DateTime.Now,
                ProductId= request.ProductId,


            };
            await _orderCommandRepository.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
