using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfessionalPortfolio.DataAccess;
using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public class AddressService : IAddressService
    {
        private readonly PortfolioDbContext _dbContext;

        public AddressService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddressAsync(int addressId)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddressWithRelatedEntitiesAsync(int addressId, string addressRelatedEntities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAddresssAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
