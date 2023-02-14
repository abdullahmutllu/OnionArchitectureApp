using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.OrderRepositories;
using OnionApp.Persistence.Context;

namespace OnionApp.Persistence.Repositories.OrderRepositories
{
    public class OrderQueryRepository : QueryRepository<Order>, IOrderQueryRepository
    {
        public OrderQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
