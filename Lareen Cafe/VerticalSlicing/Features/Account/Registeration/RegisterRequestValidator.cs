using FluentValidation;
using Microsoft.AspNetCore.Identity.Data;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Registeration
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.UserName)
                 .NotEmpty().WithMessage("اسم المستخدم مطلوب");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("البريد إلكتروني مطلوب")
                .EmailAddress().WithMessage("مطلوب بريد إلكتروني صالح");

            RuleFor(x => x.Password)
                    .NotEmpty().WithMessage("كلمة المرور مطلوبة")
                    .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")
                    .WithMessage("يجب أن تتكون كلمة المرور من 8 أحرف على الأقل، وتتضمن على الأقل حرفًا كبيرًا وحرفًا صغيرًا ورقمًا واحدًا وحرفًا خاصًا واحدًا");

        }
    }
}
