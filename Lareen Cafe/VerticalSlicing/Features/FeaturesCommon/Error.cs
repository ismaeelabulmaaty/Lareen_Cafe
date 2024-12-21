namespace LareenCafe.Api.VerticalSlicing.Features.FeaturesCommon
{
    public record Error(string Description, int? StatusCode)
    {
        public static readonly Error None = new(string.Empty, null);
    }
}
