using ProfessionalPortfolio.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public interface ISkillService
    {
        Task<Skill> GetSkillAsync(int skillId);
        Task<Skill> GetSkillWithRelatedEntitiesAsync(int skillId, string skillRelatedEntities);
        Task<IEnumerable<Skill>> GetAllSkillsAsync();
        Task CreateSkillAsync(Skill skill);
        Task UpdateSkillAsync(Skill skill);
        Task DeleteSkillAsync(Skill skill);
    }
}
