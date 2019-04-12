using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(Guid id);
        Task<int> Create(TEntity entity);
        int Update(Guid id, TEntity entity);
        Task<int> Delete(Guid id);
        Task<int> DeleteLogically(Guid id);
    }
}
