using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionApp.Presentation.BaseController
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected ApiController(IMediator mediator)
        {
            _mediator= mediator;
        }
    }
}
