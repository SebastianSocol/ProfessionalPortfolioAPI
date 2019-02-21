using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfessionalPortfolio.DataAccess;
using ProfessionalPortfolio.DataAccess.Repositories;
using ProfessionalPortfolio.Model.Models;

namespace ProfessionalPortfolio.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            await _userRepository.DeleteAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await _userRepository.GetAsync(userId);
        }

        public async Task<User> GetUserWithRelatedEntitiesAsync(int userId, string userRelatedEntities)
        {
            return await _userRepository.GetWithRelatedEntitiesAsync(userId, userRelatedEntities);
        }

        public async Task UpdateUserAsync(int userId, string phoneNumber, string emailAddress)
        {
            var userFromDb = await _userRepository.GetAsync(userId);

            userFromDb.PhoneNumber = phoneNumber;
            userFromDb.EmailAddress = emailAddress;

            await _userRepository.UpdateAsync(userFromDb);
        }
    }
}
