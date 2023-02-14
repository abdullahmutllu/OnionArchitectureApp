
using OnionApp.Application.Features.Companies.Commands.CreateCompany;
using OnionApp.Application.Features.Companies.Commands.UpdateCompany;
using OnionApp.Application.Services;
using OnionApp.Domain;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.CompanyRepositories;

namespace OnionApp.Persistence.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyCommandRepositoy _companyCommandRepositoy;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CompanyService(ICompanyCommandRepositoy companyCommandRepositoy, ICompanyQueryRepository companyQueryRepository,IUnitOfWork unitOfWork)
        {
            _companyCommandRepositoy = companyCommandRepositoy;
            _companyQueryRepository = companyQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCompanyAsync(CreateCompanyCommand request)
        {
            Company company = new()
            {
                Id = Guid.NewGuid().ToString(),
                ApprovalStatus = false,
                CompanyName = request.CompanyName,
                CreeatedDate = DateTime.Now,
                OrderStartTimeHour = request.OrderStartTimeHour,
                OrderStartTimeMinute = request.OrderStartTimeMinute,
                OrderFinishTimeHour = request.OrderFinishTimeHour,
                OrderFinishTimeMinute = request.OrderFinishTimeMinute,
            };
            await _companyCommandRepositoy.AddAsync(company);
            await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Company> GetAll()
        {
            return _companyQueryRepository.GetAll();
        }

        public async Task<Company> GetCompanyById(string companyId)
        {
            return await _companyQueryRepository.GetFirstById(companyId);
         }

        public async Task UpdateCompanyAsync(UpdateCompanyCommand request)
        {
            var company = await _companyQueryRepository.GetFirstById(request.CompanyId);
            if (company == null) throw new Exception("Şirket kaydı bulunamadı");
            if (company.ApprovalStatus == true) throw new Exception("Şirket zaten onaylı");
            company.ApprovalStatus = true;
            company.OrderStartTimeHour= request.OrderStartTimeHour;
            company.OrderStartTimeMinute = request.OrderStartTimeMinute;
            _companyCommandRepositoy.Update(company);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
