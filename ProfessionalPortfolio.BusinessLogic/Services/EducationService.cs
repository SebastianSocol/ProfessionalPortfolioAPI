using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfessionalPortfolio.DataAccess;
using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public class EducationService : IEducationService
    {
        private readonly PortfolioDbContext _dbContext;

        public EducationService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateEducationAsync(Education education)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEducationAsync(Education education)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Education>> GetAllEducationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Education> GetEducationAsync(int educationId)
        {
            throw new NotImplementedException();
        }

        public Task<Education> GetEducationWithRelatedEntitiesAsync(int EducationId, string educationRelatedEntities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEducationAsync(Education education)
        {
            throw new NotImplementedException();
        }
    }
}
