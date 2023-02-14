

using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Companies.Commands.CreateCompany;
using OnionApp.Application.Features.Companies.Commands.UpdateCompany;
using OnionApp.Application.Features.Companies.Queries.GetAllCompany;
using OnionApp.Presentation.BaseController;

namespace OnionApp.Presentation.Controller
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyCommand request)
        {
            UpdateCompanyCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllCompany()
        {
            GetAllCompanyQuery request = new();
            GettAllCompanyQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
