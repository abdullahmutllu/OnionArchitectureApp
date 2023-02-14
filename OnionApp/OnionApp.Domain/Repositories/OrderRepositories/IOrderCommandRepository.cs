using OnionApp.Domain.Entities;

namespace OnionApp.Domain.Repositories.OrderRepositories
{
    public interface IOrderCommandRepository : ICommandRepository<Order>
    {
    }
}
