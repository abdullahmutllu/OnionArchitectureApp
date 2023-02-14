using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.CompanyRepositories;
using OnionApp.Persistence.Context;

namespace OnionApp.Persistence.Repositories.CompanyRepositories
{
    public class CompanyCommandRepositoy : CommandRepository<Company>, ICompanyCommandRepositoy
    {
        public CompanyCommandRepositoy(AppDbContext context) : base(context)
        {
        }
    }
}
