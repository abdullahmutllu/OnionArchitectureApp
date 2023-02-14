using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Products.Commands.CreateProduct;
using OnionApp.Presentation.BaseController;

namespace OnionApp.Presentation.Controller
{
    public class ProductsController : ApiController
    {
        public ProductsController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request)
        {
            CreateProductCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
