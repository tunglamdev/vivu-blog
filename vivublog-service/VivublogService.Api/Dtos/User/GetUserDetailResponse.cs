using VivublogService.Application.Models.User;

namespace VivublogService.Api.Dtos.User
{
    public class GetUserDetailResponse
    {
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static GetUserDetailResponse FromModel(GetUserDetailResponseModel model)
        {
            return new GetUserDetailResponse
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
        }
    }
}
