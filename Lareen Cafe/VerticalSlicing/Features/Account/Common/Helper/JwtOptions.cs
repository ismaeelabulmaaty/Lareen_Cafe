using System.ComponentModel.DataAnnotations;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Common.Helper
{
    public class JwtOptions
    {
        public static string SectionName = "Jwt";

        [Required]
        public string Key { get; init; } = string.Empty;

        [Required]
        public string Issuer { get; init; } = string.Empty;

        [Required]
        public string Audience { get; init; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int ExpiryHours { get; init; }
    }
}
