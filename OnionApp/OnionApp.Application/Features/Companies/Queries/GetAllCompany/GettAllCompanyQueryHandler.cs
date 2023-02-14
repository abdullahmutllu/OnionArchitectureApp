using MediatR;
using OnionApp.Application.Services;

namespace OnionApp.Application.Features.Companies.Queries.GetAllCompany
{
    public record GettAllCompanyQueryHandler : IRequestHandler<GetAllCompanyQuery, GettAllCompanyQueryResponse>
    {
        private readonly ICompanyService _companyService;
        public GettAllCompanyQueryHandler(ICompanyService companyService)
        {
            _companyService= companyService;
        }
        public async Task<GettAllCompanyQueryResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {
            GettAllCompanyQueryResponse response =  new(_companyService.GetAll());
            return response;
        }
    }
}
