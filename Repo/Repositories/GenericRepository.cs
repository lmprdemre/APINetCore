using Helper.Entity;
using Microsoft.EntityFrameworkCore;
using Repo.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly EmreDbContext _dbContext;

        public GenericRepository(EmreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<int> Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            return _dbContext.SaveChangesAsync().Result;
        }

        public int Update(Guid id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChangesAsync().Result;
        }

        public async Task<int> Delete(Guid id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChangesAsync().Result;
        }

        public async Task<int> DeleteLogically(Guid id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            entity.Deleted = true;
            entity.Published = false;
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChangesAsync().Result;
        }
    }
}
