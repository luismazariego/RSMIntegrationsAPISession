using Domain.Primitives;

namespace Domain.Models
{
    public class Department : Entity
    {
        public string? Name { get; set; }
        public string? GroupName { get; set; }
    }
}
