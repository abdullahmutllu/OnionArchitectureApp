using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Base;

namespace OnionApp.Domain.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Entity { get; set; }

    }
}
