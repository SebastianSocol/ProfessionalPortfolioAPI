using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public class SkillRepository : Repository<Skill>, ISkillRepository
    {
        public SkillRepository(PortfolioDbContext dbContext) : base(dbContext)
        {

        }
    }
}
