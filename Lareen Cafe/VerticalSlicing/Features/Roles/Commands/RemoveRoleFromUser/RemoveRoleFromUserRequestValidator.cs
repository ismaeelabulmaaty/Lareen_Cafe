using FluentValidation;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRoleFromUser
{
    public class RemoveRoleFromUserRequestValidator : AbstractValidator<RemoveRoleFromUserRequest>
    {
        public RemoveRoleFromUserRequestValidator()
        {
            RuleFor(x => x.RoleId)
                 .NotEmpty().WithMessage("RoleName is required");
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId Is required");
        }
    }
}
