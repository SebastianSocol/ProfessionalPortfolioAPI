using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.DataAccess.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(PortfolioDbContext dbContext) : base(dbContext)
        {
        }
    }
}
