using VivublogService.Application.Interfaces.Repositories;
using VivublogService.Application.Interfaces.Services;
using VivublogService.Application.Models.User;

namespace VivublogService.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public async Task<GetUserDetailResponseModel> GetUserDetailAsync(string userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);

            return GetUserDetailResponseModel.FromEntity(user);
        }
    }
}
