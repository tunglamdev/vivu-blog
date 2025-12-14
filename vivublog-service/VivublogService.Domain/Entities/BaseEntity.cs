using System.ComponentModel.DataAnnotations;

namespace VivublogService.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; } = null!;
    }
}
