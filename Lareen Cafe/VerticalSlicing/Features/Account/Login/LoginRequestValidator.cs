using FluentValidation;
using Microsoft.AspNetCore.Identity.Data;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Login
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Email)
                 .NotEmpty().WithMessage("البريد الإلكتروني مطلوب\r\n");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("كلمة المرور مطلوبة");
        }
    }
}
