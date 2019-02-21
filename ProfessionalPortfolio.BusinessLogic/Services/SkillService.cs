using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfessionalPortfolio.DataAccess;
using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public class SkillService : ISkillService
    {
        private readonly PortfolioDbContext _dbContext;

        public SkillService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateSkillAsync(Skill skill)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSkillAsync(Skill skill)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Skill>> GetAllSkillsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Skill> GetSkillAsync(int skillId)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> GetSkillWithRelatedEntitiesAsync(int skillId, string skillRelatedEntities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSkillAsync(Skill skill)
        {
            throw new NotImplementedException();
        }
    }
}
