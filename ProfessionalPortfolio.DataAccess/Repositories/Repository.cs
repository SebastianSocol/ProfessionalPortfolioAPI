using Microsoft.EntityFrameworkCore;
using ProfessionalPortfolio.Model.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly PortfolioDbContext DbContext;

        public Repository(PortfolioDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            await DbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task DeleteAsync(int entityId)
        {
            var entity = await GetAsync(entityId);

            await Task.Run(() => DbContext.Set<TEntity>().Remove(entity));
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllWithRelatedEntitiesAsync(string relatedEntities)
        {
            IQueryable<TEntity> query = DbContext.Set<TEntity>();

            if (!string.IsNullOrEmpty(relatedEntities))
            {
                var entities = relatedEntities.Split(',');

                foreach (var entity in entities)
                {
                    query = query.Include(entity);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await DbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> GetWithRelatedEntitiesAsync(int id, string relatedEntities)
        {
            IQueryable<TEntity> query = DbContext.Set<TEntity>();

            if (!string.IsNullOrEmpty(relatedEntities))
            {
                var entities = relatedEntities.Split(',');

                foreach (var entity in entities)
                {
                    query = query.Include(entity);
                }
            }

            return await query.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => DbContext.Set<TEntity>().Update(entity));
        }
    }
}
