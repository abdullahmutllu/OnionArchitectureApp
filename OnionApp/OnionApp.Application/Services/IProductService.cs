using OnionApp.Application.Features.Products.Commands.CreateProduct;

namespace OnionApp.Application.Services
{
    public interface IProductService
    {
        Task AddAsync(CreateProductCommand reguest);
    }
}
