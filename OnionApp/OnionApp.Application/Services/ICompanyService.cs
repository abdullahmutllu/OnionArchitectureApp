using OnionApp.Application.Features.Companies.Commands.CreateCompany;
using OnionApp.Application.Features.Companies.Commands.UpdateCompany;
using OnionApp.Domain.Entities;

namespace OnionApp.Application.Services
{
    public interface ICompanyService
    {
        Task CreateCompanyAsync(CreateCompanyCommand request);
        Task UpdateCompanyAsync(UpdateCompanyCommand request);
        IQueryable<Company> GetAll();
        Task<Company> GetCompanyById(string companyId);
    }
}
