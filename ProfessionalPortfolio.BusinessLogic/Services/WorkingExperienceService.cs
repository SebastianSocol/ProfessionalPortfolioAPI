using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfessionalPortfolio.DataAccess;
using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public class WorkingExperienceService : IWorkingExperienceService
    {
        private readonly PortfolioDbContext _dbContext;

        public WorkingExperienceService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateWorkingExperienceAsync(WorkingExperience workingExperience)
        {
            throw new NotImplementedException();
        }

        public Task DeleteWorkingExperienceAsync(WorkingExperience workingExperience)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkingExperience>> GetAllWorkingExweriencesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WorkingExperience> GetWorkingExperienceAsync(int workingExperienceId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkingExperience> GetWorkingExperienceWithRelatedEntitiesAsync(int workingExperienceId, string workingExperienceRelatedEntities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateWorkingExperienceAsync(WorkingExperience workingExperience)
        {
            throw new NotImplementedException();
        }
    }
}
