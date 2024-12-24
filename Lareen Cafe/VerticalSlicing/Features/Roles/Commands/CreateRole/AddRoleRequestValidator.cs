using FluentValidation;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.CreateRole
{
    public class AddRoleRequestValidator : AbstractValidator<AddRoleRequest>
    {
        public AddRoleRequestValidator()
        {
            RuleFor(x => x.RoleName)
                 .NotEmpty().WithMessage("اسم الدور مطلوب");
        }
    }
}
