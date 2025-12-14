using VivublogService.Application.Interfaces.Repositories;
using VivublogService.Domain.Entities;

namespace VivublogService.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User?> GetUserByIdAsync(string userId)
        {
            return new User
            {
                Id = userId,
                FirstName = "Bill",
                LastName = "Gates",
                Email = "billgates@gmail.com"
            };
        }
    }
}
