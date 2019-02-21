using ProfessionalPortfolio.Model.Models.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> GetAsync(int id);

        Task<TEntity> GetWithRelatedEntitiesAsync(int id, string relatedEntities);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(int entityId);
    }
}
