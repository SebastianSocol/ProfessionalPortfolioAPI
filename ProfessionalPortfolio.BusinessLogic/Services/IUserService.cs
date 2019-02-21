using ProfessionalPortfolio.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int userId);

        Task<User> GetUserWithRelatedEntitiesAsync(int userId, string userRelatedEntities);

        Task<IEnumerable<User>> GetAllUsersAsync();

        Task CreateUserAsync(User user);

        Task UpdateUserAsync(int userId, string phoneNumber, string emailAddress);

        Task DeleteUserAsync(int userId);
    }
}
