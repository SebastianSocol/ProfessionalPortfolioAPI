using ProfessionalPortfolio.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public interface IEducationService
    {
        Task<Education> GetEducationAsync(int educationId);
        Task<Education> GetEducationWithRelatedEntitiesAsync(int EducationId, string educationRelatedEntities);
        Task<IEnumerable<Education>> GetAllEducationsAsync();
        Task CreateEducationAsync(Education education);
        Task UpdateEducationAsync(Education education);
        Task DeleteEducationAsync(Education education);
    }
}
