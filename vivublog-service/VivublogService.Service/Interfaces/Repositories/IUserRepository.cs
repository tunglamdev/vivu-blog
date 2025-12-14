using VivublogService.Domain.Entities;

namespace VivublogService.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByIdAsync(string userId);
    }
}
