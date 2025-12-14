using VivublogService.Application.Models.User;

namespace VivublogService.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<GetUserDetailResponseModel> GetUserDetailAsync(string userId);
    }
}
