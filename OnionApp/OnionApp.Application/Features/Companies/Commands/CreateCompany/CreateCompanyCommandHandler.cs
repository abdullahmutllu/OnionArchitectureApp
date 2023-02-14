using MediatR;
using MediatR.Pipeline;
using OnionApp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Companies.Commands.CreateCompany
{
    public record CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;
        public CreateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService= companyService;
        }
   
        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            await _companyService.CreateCompanyAsync(request);
            return new CreateCompanyCommandResponse();
        }
    }
}
