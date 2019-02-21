using ProfessionalPortfolio.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public interface IAddressService
    {
        Task<Address> GetAddressAsync(int addressId);
        Task<Address> GetAddressWithRelatedEntitiesAsync(int addressId, string addressRelatedEntities);
        Task<IEnumerable<Address>> GetAllAddresssAsync();
        Task CreateAddressAsync(Address address);
        Task UpdateAddressAsync(Address address);
        Task DeleteAddressAsync(Address address);
    }
}
