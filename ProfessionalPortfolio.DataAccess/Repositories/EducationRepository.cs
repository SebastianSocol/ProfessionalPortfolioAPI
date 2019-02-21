using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public class EducationRepository : Repository<Education>, IEducationRepository
    {
        public EducationRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
