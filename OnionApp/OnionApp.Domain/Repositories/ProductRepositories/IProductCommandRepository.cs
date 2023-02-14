using OnionApp.Domain.Entities;

namespace OnionApp.Domain.Repositories.ProductRepositories
{
    public interface IProductCommandRepository : ICommandRepository<Product>
    {
    }
}
