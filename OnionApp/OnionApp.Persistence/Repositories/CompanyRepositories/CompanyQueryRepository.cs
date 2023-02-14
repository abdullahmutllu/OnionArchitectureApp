using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.CompanyRepositories;
using OnionApp.Persistence.Context;

namespace OnionApp.Persistence.Repositories.CompanyRepositories
{
    public class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
