using MediatR;
using OnionApp.Application.Services;

namespace OnionApp.Application.Features.Companies.Commands.UpdateCompany
{
    public record UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;
        public UpdateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            await _companyService.UpdateCompanyAsync(request);
            return new UpdateCompanyCommandResponse();
        }
    }
}
