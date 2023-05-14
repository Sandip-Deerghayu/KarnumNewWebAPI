
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KranumDataAccess.Repository
{

    public abstract class KranumBaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext _context;

        public KranumBaseRepository(TContext context)
        {
            _context = context;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public Task<TEntity> DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return Task.FromResult(entity);
        }

        public Task DeleteRangeAsync(List<TEntity> entity)
        {
            _context.Set<TEntity>().RemoveRange(entity);
            return Task.FromResult(entity);
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            return entity;
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        //public async Task<TEntity> GetByUUIDAsync(string uuid, bool isUpdate = false)
        //{
        //    var entity = await _context.Set<TEntity>().Where(x => x.Uuid == uuid).AsNoTracking().FirstOrDefaultAsync();

        //    if (entity == null)
        //    {
        //        return null;
        //    }

        //    if (isUpdate)
        //    {
        //        return await this.GetAsync(entity.Id);
        //    }
        //    else
        //    {
        //        return await _context.Set<TEntity>().FindAsync(entity.Id);
        //    }

        //}

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<TEntity>().Update(entity);
            return Task.FromResult<TEntity>(entity);
        }

        public List<TEntity> GetByQuery(Expression<Func<TEntity, bool>> Predicate)
        {
            return _context.Set<TEntity>().Where(Predicate).Select(x => x).ToList();
        }
    }
}

