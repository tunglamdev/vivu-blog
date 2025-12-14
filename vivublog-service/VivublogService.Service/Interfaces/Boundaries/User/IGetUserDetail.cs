using VivublogService.Application.Models.User;

namespace VivublogService.Application.Interfaces.Boundaries.User
{
    public interface IGetUserDetail
    {
        Task<Response> ExecuteAsync(Request request);

        public class Request
        {
            public string UserId { get; set; }

            public Request(string userId)
            {
                UserId = userId;
            }
        }

        public class Response
        {
            public GetUserDetailResponseModel UserDetail { get; set; }

            public Response(GetUserDetailResponseModel userDetail)
            {
                UserDetail = userDetail;
            }
        }
    }
}
