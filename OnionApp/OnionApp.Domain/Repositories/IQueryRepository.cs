using OnionApp.Domain.Base;
using System.Linq.Expressions;

namespace OnionApp.Domain.Repositories
{
    public interface IQueryRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expression);
        Task<T> GetFirstByExpression(Expression<Func<T,bool>> expression);
        Task<T> GetFirstById(string id);
    }
}
