using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Orders.Commands.CreateOrderCommand;
using OnionApp.Presentation.BaseController;

namespace OnionApp.Presentation.Controller
{
    public class OrdersController : ApiController
    {
        public OrdersController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
        {
            CreateOrderCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
