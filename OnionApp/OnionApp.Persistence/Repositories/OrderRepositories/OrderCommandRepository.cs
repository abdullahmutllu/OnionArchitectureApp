using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.OrderRepositories;
using OnionApp.Persistence.Context;

namespace OnionApp.Persistence.Repositories.OrderRepositories
{
    public class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
    {
        public OrderCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
