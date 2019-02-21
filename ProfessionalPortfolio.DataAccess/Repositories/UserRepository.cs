using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
