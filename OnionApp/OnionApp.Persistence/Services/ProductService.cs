

using OnionApp.Application.Features.Products.Commands.CreateProduct;
using OnionApp.Application.Services;
using OnionApp.Domain;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.ProductRepositories;

namespace OnionApp.Persistence.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductCommandRepository _productCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductCommandRepository productCommandRepository, IUnitOfWork unitOfWork)
        {
            _productCommandRepository = productCommandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(CreateProductCommand reguest)
        {
            Product product = new()
            {
                Id = Guid.NewGuid().ToString(),
                CompanyId = reguest.CompanyId,
                CreeatedDate = DateTime.Now,
                ProductName = reguest.ProductName,
                Price = reguest.Price,
                Stock = reguest.Stock,
            };
            await _productCommandRepository.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
