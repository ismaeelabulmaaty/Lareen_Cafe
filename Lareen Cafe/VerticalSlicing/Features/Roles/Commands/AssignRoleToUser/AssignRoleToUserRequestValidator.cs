using FluentValidation;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.AssignRoleToUser
{
    public class AssignRoleToUserRequestValidator : AbstractValidator<AssignRoleToUserRequest>
    {
        public AssignRoleToUserRequestValidator()
        {
            RuleFor(x => x.RoleName)
                 .NotEmpty().WithMessage("اسم الدور مطلوب");
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("معرف المستخدم مطلوب");
        }
    }
}
