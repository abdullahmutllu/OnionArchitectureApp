using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.ProductRepositories;
using OnionApp.Persistence.Context;

namespace OnionApp.Persistence.Repositories.ProductRepositories
{
    public class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
    {
        public ProductQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
