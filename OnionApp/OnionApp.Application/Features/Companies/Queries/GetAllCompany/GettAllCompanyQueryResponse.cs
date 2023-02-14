using OnionApp.Domain.Entities;

namespace OnionApp.Application.Features.Companies.Queries.GetAllCompany
{
    public record GettAllCompanyQueryResponse(IQueryable<Company> Companies);
 
}
