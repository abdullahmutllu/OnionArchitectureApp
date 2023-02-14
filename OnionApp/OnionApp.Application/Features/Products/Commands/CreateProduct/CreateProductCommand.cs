using MediatR;

namespace OnionApp.Application.Features.Products.Commands.CreateProduct
{
    public  record CreateProductCommand(string CompanyId,string ProductName,decimal Stock,decimal Price) : IRequest<CreateProductCommandResponse>;
  
}
