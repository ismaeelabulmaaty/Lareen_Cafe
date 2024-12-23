using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();

        public ICollection<RefreshToken>? RefreshTokens { get; set; } = new List<RefreshToken>();


    }
}
