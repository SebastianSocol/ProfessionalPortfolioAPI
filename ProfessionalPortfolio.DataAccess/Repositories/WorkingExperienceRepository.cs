using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public class WorkingExperienceRepository : Repository<WorkingExperience>, IWorkingExperienceRepository
    {
        public WorkingExperienceRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
