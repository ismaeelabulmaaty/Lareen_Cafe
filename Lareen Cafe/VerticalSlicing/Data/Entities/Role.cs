using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}
