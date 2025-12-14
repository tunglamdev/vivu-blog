using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using VivublogService.Api.Dtos.User;
using VivublogService.Application.Interfaces.Boundaries.User;

namespace VivublogService.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IGetUserDetail _getUserDetail;

        public UsersController(IGetUserDetail getUserDetail)
        {
            _getUserDetail = getUserDetail;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserDetail(string userId)
        {
            var request = new IGetUserDetail.Request(userId);
            var response = await _getUserDetail.ExecuteAsync(request);
            var result = GetUserDetailResponse.FromModel(response.UserDetail);
            return Ok(result);
        }
    }
}
