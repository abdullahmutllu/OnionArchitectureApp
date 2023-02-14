using MediatR;

namespace OnionApp.Application.Features.Companies.Queries.GetAllCompany
{
    public record GetAllCompanyQuery(): IRequest<GettAllCompanyQueryResponse>;
}
