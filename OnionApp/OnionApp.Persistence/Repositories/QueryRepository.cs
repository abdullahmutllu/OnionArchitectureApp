using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Base;
using OnionApp.Domain.Repositories;
using OnionApp.Persistence.Context;
using System.Linq.Expressions;

namespace OnionApp.Persistence.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly Func<AppDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((AppDbContext context,string id)=>context.Set<T>().FirstOrDefault(x=>x.Id == id));
        public QueryRepository(AppDbContext context)
        {
            _context= context;
            Entity = _context.Set<T>();
        }
        public DbSet<T> Entity { get; set; }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
     
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetFirstById(string id)
        {
            return await GetByIdCompiled(_context,id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}
