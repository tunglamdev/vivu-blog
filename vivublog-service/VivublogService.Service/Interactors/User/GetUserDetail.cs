using VivublogService.Application.Interfaces.Boundaries.User;
using VivublogService.Application.Interfaces.Services;

namespace VivublogService.Application.Interactors.User
{
    public class GetUserDetail : IGetUserDetail
    {
        private readonly IUserService _userService;

        public GetUserDetail(IUserService userService) 
        { 
            _userService = userService;
        }

        public async Task<IGetUserDetail.Response> ExecuteAsync(IGetUserDetail.Request request)
        {
            var user = await _userService.GetUserDetailAsync(request.UserId);
            return new IGetUserDetail.Response(user);
        }
    }
}
