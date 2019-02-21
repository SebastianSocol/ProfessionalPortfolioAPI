using ProfessionalPortfolio.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public interface IWorkingExperienceService
    {
        Task<WorkingExperience> GetWorkingExperienceAsync(int workingExperienceId);
        Task<WorkingExperience> GetWorkingExperienceWithRelatedEntitiesAsync(int workingExperienceId, string workingExperienceRelatedEntities);
        Task<IEnumerable<WorkingExperience>> GetAllWorkingExweriencesAsync();
        Task CreateWorkingExperienceAsync(WorkingExperience workingExperience);
        Task UpdateWorkingExperienceAsync(WorkingExperience workingExperience);
        Task DeleteWorkingExperienceAsync(WorkingExperience workingExperience);
    }
}
