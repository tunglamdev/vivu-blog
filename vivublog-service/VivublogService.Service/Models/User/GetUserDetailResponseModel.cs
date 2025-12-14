namespace VivublogService.Application.Models.User
{
    public class GetUserDetailResponseModel
    {
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static GetUserDetailResponseModel FromEntity(Domain.Entities.User user)
        {
            return new GetUserDetailResponseModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}
